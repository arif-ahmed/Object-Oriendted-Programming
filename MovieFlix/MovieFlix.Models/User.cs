using MovieFlix.Models.Contracts;

namespace MovieFlix.Models
{
    public class User : IEntity, IUser
    {
        private readonly List<Movie> watchList = new();
        private readonly List<Movie> watchedHistories = new();
        public int Id { get; private set; }
        public string Name { get; private set; }

        public IReadOnlyCollection<Movie> WatchList { get; }
        public IReadOnlyCollection<Movie> WatchedHistories { get; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
            WatchList = watchList.AsReadOnly();
            WatchedHistories = watchedHistories.AsReadOnly();
        }

        public void AddMovieToWatchList(Movie movie)
        {
            watchList.Add(movie);
        }

        public void AddMovieToWatchedList(Movie movie)
        {
            watchedHistories.Add(movie);
        }

        public void RateMovie(int rating, Movie movie)
        {
            movie.Rating = rating;
        }
    }
}
