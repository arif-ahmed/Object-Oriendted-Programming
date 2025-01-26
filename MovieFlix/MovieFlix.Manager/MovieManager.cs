
using MovieFlix.Manager.Contracts;
using MovieFlix.Models;
using MovieFlix.Repositories.Contracts;
using System.Linq.Expressions;

namespace MovieFlix.Manager
{
    public class MovieManager : IMovieManager
    {
        private readonly IRepository<Movie> _repository;

        public MovieManager(IRepository<Movie> repository)
        {
            _repository = repository;
        }

        public async Task AddMovie(Movie movie)
        {
            await _repository.Insert(movie);
        }

        public async Task DeleteMovie(Movie movie)
        {
            await _repository.Insert(movie);
        }

        public async Task<Movie> GetMovieById(int id)
        {
            return await _repository.FindById(id);
        }

        public async Task<Movie> GetMovieByName(string title)
        {
            var movies = await _repository.Filter(x => x.Title == title);
            
            
            return await Task.FromResult(movies.ToList().FirstOrDefault());
        } 

        public async Task<List<Movie>> SearchMovies(Expression<Func<Movie, bool>> expression)
        {
            var movies = await _repository.Filter(expression);
            return await Task.FromResult(movies.ToList());
        }

        public async Task UpdateMovie(int id, Movie movie)
        {
            await _repository.Update(movie);
        }
    }
}
