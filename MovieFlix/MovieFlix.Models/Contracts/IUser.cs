namespace MovieFlix.Models.Contracts
{
    public interface IUser
    {
        void AddMovieToWatchList(Movie movie);
        void AddMovieToWatchedList(Movie movie);
        void RateMovie(int rating, Movie movie);
    }
}
