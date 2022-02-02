using MovieFlix.Manager.Contracts;
using MovieFlix.Models;
using MovieFlix.Models.Contracts;
using MovieFlix.Repositories.Contracts;
using MovieFlix.Utilities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace MovieFlix.Manager
{
    public class UserManager : IUserManager
    {
        private readonly IRepository<Movie> _movieRepository;
        private readonly IRepository<User> _userRepository;
        public UserManager(IRepository<Movie> movieRepository, IRepository<User> userRepository) 
        {
            _movieRepository = movieRepository;
            _userRepository = userRepository;
        }
        public async Task AddMovieToWatchHistory(int userId, int movieId, int rating)
        {
            User user = await _userRepository.FindById(userId);

            if (user == null)
            {
                throw new InvalidOperationException($"No user found with id: {userId}");
            }

            Movie movie = await _movieRepository.FindById(movieId);

            if (movie == null)
            {
                throw new InvalidOperationException($"No movie found with id: {movieId}");
            }

            user.AddMovieToWatchedList(movie);
            movie.Rating = rating;
            await _userRepository.Update(user);
            await _movieRepository.Update(movie);
        }

        public async Task AddMovieToWatchList(int userId, int movieId)
        {
            User user = await _userRepository.FindById(userId);

            if (user == null) 
            {
                throw new InvalidOperationException($"No user found with id: {userId}");
            }

            Movie movie = await _movieRepository.FindById(movieId);

            if (movie == null)
            {
                throw new InvalidOperationException($"No movie found with id: {movieId}");
            }

            user.AddMovieToWatchList(movie);
            await _userRepository.Update(user);
        }

        public async Task DeleteUser(int id)
        {
            await _userRepository.Delete(id);
        }

        public async Task<List<Movie>> GetRecommendedMovies(int userId)
        {
            User user = await _userRepository.FindById(userId);

            if (user == null)
            {
                throw new InvalidOperationException($"No user found with id: {userId}");
            }

            List<Genre> genres = user.WatchedHistories.Select(x => x.Genre).ToList();
            List<Movie> movies = user.WatchList
                .Where(x => genres.Contains(x.Genre))
                .Where(x => !user.WatchedHistories.Select(wh => wh.Id).Contains(x.Id))
                .ToList();
            return await Task.FromResult(movies);
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.FindById(id);
        }

        public async Task InsertUser(User user)
        {
            await _userRepository.Insert(user);
        }

        public async Task UpdateUser(int id, User user)
        {
            await _userRepository.Update(user);
        }

        public async Task<IEnumerable<Movie>> GetWatchList(int userId)
        {
            var user = await _userRepository.FindById(userId);
            return user?.WatchList ?? Enumerable.Empty<Movie>();
        }
    }
}
