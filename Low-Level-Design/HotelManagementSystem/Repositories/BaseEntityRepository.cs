using HotelManagementSystem.Contracts;
using HotelManagementSystem.Models;
using System.Linq.Expressions;
using System.Reflection;

namespace HotelManagementSystem.Repositories;
public abstract class BaseEntityRepository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
{
    private readonly List<TEntity> _collection = [];
    public Task AddAsync(TEntity entity)
    {
        _collection.Add(entity);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(int id)
    {
        _collection.RemoveAt(id);
        return Task.CompletedTask;
    }

    public Task<IEnumerable<TEntity>> Filter(
        Expression<Func<TEntity, bool>> expression,
        string sortBy =  "Id",
        string sortOrder = "asc",
        int page = 0,
        int limit = 100)
    {
        var query = _collection.AsQueryable().Where(expression);

        // Apply dynamic sorting
        if (!string.IsNullOrWhiteSpace(sortBy))
        {
            // Get property info
            var property = typeof(TEntity).GetProperty(sortBy, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
            if (property == null)
                throw new ArgumentException($"Property '{sortBy}' not found on type '{typeof(TEntity).Name}'.");

            var parameter = Expression.Parameter(typeof(TEntity), "x");
            var propertyAccess = Expression.MakeMemberAccess(parameter, property);
            var orderByExpression = Expression.Lambda(propertyAccess, parameter);

            string methodName = sortOrder.ToLower() == "desc" ? "OrderByDescending" : "OrderBy";

            var resultExpression = Expression.Call(
                typeof(Queryable),
                methodName,
                new Type[] { typeof(TEntity), property.PropertyType },
                query.Expression,
                Expression.Quote(orderByExpression));

            query = query.Provider.CreateQuery<TEntity>(resultExpression);
        }

        var result = query.Skip(page).Take(limit).ToList();
        return Task.FromResult<IEnumerable<TEntity>>(result);
    }

    public Task<IEnumerable<TEntity>> GetAllAsync()
    {
        var entities = _collection.ToList();
        return Task.FromResult<IEnumerable<TEntity>>(entities);
    }

    public Task<TEntity> GetByIdAsync(int id)
    {
        var entity = _collection.FirstOrDefault(e => e.Id == id);
        if (entity is null)
            throw new InvalidOperationException($"Entity with ID {id} not found.");

        return Task.FromResult(entity);
    }

    public Task<bool> SaveChangesAsync()
    {
        return Task.FromResult(true);
    }

    public Task UpdateAsync(TEntity entity)
    {
        var entityToUpdateIndex = _collection.FindIndex(e => e.Id == entity.Id);

        if (entityToUpdateIndex < 0)
            throw new InvalidOperationException($"Entity with ID {entity.Id} not found for update.");

        _collection[entityToUpdateIndex] = entity;
        return Task.CompletedTask;
    }
}
