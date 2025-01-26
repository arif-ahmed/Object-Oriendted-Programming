using MovieFlix.Models.Contracts;
using System.Linq.Expressions;

namespace MovieFlix.Repositories.Contracts
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> FindById(int id);
        Task<IQueryable<TEntity>> Filter(Expression<Func<TEntity, bool>> expression);
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int id);
    }
}
