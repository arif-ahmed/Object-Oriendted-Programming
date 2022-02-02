using MovieFlix.FakeDataStore;
using MovieFlix.Models;
using MovieFlix.Repositories.Contracts;
using System.Linq;
using System.Linq.Expressions;

namespace MovieFlix.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly FakeDbContext _dbContext;

        public UserRepository(FakeDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task Delete(int id)
        {
            User user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            _dbContext.Users.Remove(user);
        }

        public async Task<IQueryable<User>> Filter(Expression<Func<User, bool>> expression)
        {
            var queryExpression = expression.Compile();
            var users = _dbContext.Users.Where(queryExpression).AsQueryable();
            return await Task.FromResult(users);
        }

        public async Task<User?> FindById(int id)
        {
            return await Task.FromResult(_dbContext.Users.FirstOrDefault(user => user.Id == id));
        }

        public async Task Insert(User entity)
        {
            _dbContext.Users.Add(entity);
        }

        public async Task Update(User entity)
        {
            int index = _dbContext.Users.FindIndex(x => x.Id == entity.Id);
            _dbContext.Users[index] = entity;
        }
    }
}
