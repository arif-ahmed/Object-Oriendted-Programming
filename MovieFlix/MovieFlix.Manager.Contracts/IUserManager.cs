using System.Collections.Generic;
using System.Threading.Tasks;
using MovieFlix.Models;

namespace MovieFlix.Manager.Contracts
{
    public interface IUserManager
    {
        Task<IEnumerable<Movie>> GetWatchList(int userId);
        Task AddMovieToWatchHistory(int userId, int movieId, int rating);
        Task AddMovieToWatchList(int userId, int movieId);
        Task DeleteUser(int id);
        Task<List<Movie>> GetRecommendedMovies(int userId);
        Task<User> GetUserById(int id);
        Task InsertUser(User user);
        Task UpdateUser(int id, User user);
    }
} 