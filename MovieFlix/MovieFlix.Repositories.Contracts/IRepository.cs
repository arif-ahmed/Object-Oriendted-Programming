using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MovieFlix.Repositories.Contracts
{
    public interface IRepository<T> where T : class
    {
        Task<T?> FindById(int id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(int id);
        Task<IQueryable<T>> Filter(Expression<Func<T, bool>> expression);
    }
} 