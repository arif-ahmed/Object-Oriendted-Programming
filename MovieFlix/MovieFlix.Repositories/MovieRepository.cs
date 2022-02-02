using MovieFlix.FakeDataStore;
using MovieFlix.Models;
using MovieFlix.Repositories.Contracts;
using System.Linq;
using System.Linq.Expressions;

namespace MovieFlix.Repositories
{
    public class MovieRepository : IRepository<Movie>
    {
        private readonly FakeDbContext _dbContext;
        public MovieRepository(FakeDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task Delete(int id)
        {
            Movie movie = _dbContext.Movies.FirstOrDefault(x => x.Id == id);
            _dbContext.Movies.Remove(movie);
        }

        public async Task<IQueryable<Movie>> Filter(Expression<Func<Movie, bool>> expression)
        {
            var queryExpression =  expression.Compile();
            var movies = _dbContext.Movies.Where(queryExpression).AsQueryable();
            return await Task.FromResult(movies);
        }

        public async Task<Movie> FindById(int id)
        {
            return await Task.FromResult(_dbContext.Movies.First(movie => movie.Id == id));
        }

        public async Task Insert(Movie entity)
        {
            _dbContext.Movies.Add(entity);
        }

        public async Task Update(Movie entity)
        {
            int index = _dbContext.Movies.FindIndex(x => x.Id == entity.Id);
            _dbContext.Movies[index] = entity;            
        }
    }
}
