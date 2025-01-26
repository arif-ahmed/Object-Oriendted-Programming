using MovieFlix.Utilities;

namespace MovieFlix.Models.Tests
{
    public class MovieTests
    {
        public MovieTests() 
        {

        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        public void Test_MovieRating(int rating, int expectedRating)
        {
            Movie movie = new Movie(1, "Champions", "Description", Genre.Drama);
            movie.Rating = rating;
            Assert.Equal(expectedRating, movie.Rating);
        }

        [Theory]
        [InlineData(-1, -1)]
        [InlineData(0, 0)]
        [InlineData(20, 20)]
        public void Test_MovieThrowsExpectionForInvalidRating(int rating, int expectedRating) 
        {
            Movie movie = new Movie(1, "Champions", "Description", Genre.Drama);
            ArgumentException exception = Assert.Throws<ArgumentException>(() => { movie.Rating = rating; });
            Assert.Equal("Rating must be between 1 to 10", exception.Message);
        }

        [Fact]
        public void Test()
        {
            Movie movie = new Movie(1, "Champions", "Description", Genre.Drama);
            movie.Rating = 5;
            movie.Rating = 6;

            Assert.Equal(6, movie.Rating);
        }
    }
}
