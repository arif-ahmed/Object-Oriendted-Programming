using HotelManagementSystem.Models;
using System.Linq.Expressions;

namespace HotelManagementSystem.Contracts;
public interface IRepository<TEntity> where TEntity : EntityBase
{
    Task<TEntity> GetByIdAsync(int id);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<IEnumerable<TEntity>> Filter(Expression<Func<TEntity, bool>> expression, string sortBy = "Id", string sortOrder = "asc", int page = 0, int limit = 100);
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(int id);
    Task<bool> SaveChangesAsync();
}
