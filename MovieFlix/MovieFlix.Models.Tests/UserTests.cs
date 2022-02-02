using Moq;
using MovieFlix.Utilities;

namespace MovieFlix.Models.Tests
{
    public class UserTests : IDisposable
    {
        public UserTests() 
        {

        }

        [Fact]
        public void Test_AddMovieToWatchList()
        {
            User user = new User(1, "Arif");
            Movie movie = new Movie(1, "A", "A", Genre.Drama);
            user.AddMovieToWatchList(movie);

            Assert.Equal(1, user.WatchList.Count);
        }

        [Fact]
        public void Test_AddMovieToWatchedList() 
        {
            User user = new User(1, "Arif");
            Movie movie = new Movie(1, "A", "A", Genre.Drama);
            user.AddMovieToWatchedList(movie);

            Assert.Equal(1, user.WatchedHistories.Count);
        }

        [Fact]
        public void Test_RateMovie()
        {
            User userA = new User(1, "Arif");
            User userB = new User(2, "Atiq");
            Movie movie = new Movie(1, "A", "A", Genre.Drama);

            userA.RateMovie(5, movie);
            userB.RateMovie(6, movie);

            Assert.Equal(6, movie.Rating);
        }

        public void Dispose()
        {

        }
    }
}
