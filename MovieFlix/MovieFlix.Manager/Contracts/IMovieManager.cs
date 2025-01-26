
using MovieFlix.Models;
using System.Linq.Expressions;

namespace MovieFlix.Manager.Contracts
{
    public interface IMovieManager
    {
        Task<Movie> GetMovieById(int id);
        Task<Movie> GetMovieByName(string title);
        Task<List<Movie>> SearchMovies(Expression<Func<Movie, bool>> expression);
        Task AddMovie(Movie movie);
        Task UpdateMovie(int id, Movie movie);
        Task DeleteMovie(Movie movie);
    }
}
