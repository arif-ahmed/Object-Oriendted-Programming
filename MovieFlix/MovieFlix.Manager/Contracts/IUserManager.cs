using MovieFlix.Models;

namespace MovieFlix.Manager.Contracts
{
    public interface IUserManager
    {
        Task InsertUser(User user);
        Task UpdateUser(int id, User user);
        Task DeleteUser(int id);
        Task<User> GetUserById(int id);
        Task AddMovieToWatchList(int userId, int movieId);
        Task AddMovieToWatchHistory(int userId, int movieId, int rating);
        Task<List<Movie>> GetRecommendedMovies(int userId);
    }
}
