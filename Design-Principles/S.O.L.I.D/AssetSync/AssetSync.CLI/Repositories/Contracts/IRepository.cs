using System.Linq.Expressions;

namespace AssetSync.CLI.Repositories.Contracts
{
    public interface IRepository<TEntity>
    {
        Task Insert(TEntity entity);
        Task<IQueryable<TEntity>> Search(Expression<Func<TEntity, bool>> expression);
    }
}
