using Moq;
using MovieFlix.FakeDataStore;
using MovieFlix.Manager.Contracts;
using MovieFlix.Models;
using MovieFlix.Repositories;
using MovieFlix.Repositories.Contracts;
using MovieFlix.Utilities;

namespace MovieFlix.Manager.Tests
{
    public class MovieManagerTests
    {
        private readonly Mock<IRepository<Movie>> movieRepositoryMock;
        private readonly MovieManager movieManager;
        
        public MovieManagerTests()
        {
            movieRepositoryMock = new Mock<IRepository<Movie>>();
            movieManager = new MovieManager(movieRepositoryMock.Object);

            movieRepositoryMock.Setup(repo => repo.FindById(1)).ReturnsAsync(new Movie(1, "Iron Man", "Iron Man", Genre.Drama));
            // movieManagerMock.Setup(manager => manager.GetMovieById(1)).ReturnsAsync(new Movie(1, "Iron Man", "Iron Man"));
        }


        [Theory]
        [InlineData(1)]
        public async Task Test_MovieManager_GetMovieById(int id)
        {
            Movie movie = await movieManager.GetMovieById(id);
            Assert.NotNull(movie);
            Assert.IsType<Movie>(movie);
            Assert.Equal("Iron Man", movie.Title);
        }

        [Fact]
        public async Task Test_MovieManager_InsertNewMovie()
        {
            // Arrange
            FakeDbContext dbContext = new FakeDbContext();
            IRepository<Movie> repository = new MovieRepository(dbContext);
            IMovieManager movieManager = new MovieManager(repository);
            // Act 
            await movieManager.AddMovie(new Movie(1, "Iron Man", "Iron Man", Genre.Action));
            await movieManager.AddMovie(new Movie(1, "Iron Man 2", "Iron Man 2", Genre.Action));

            // Asset
            Assert.True(dbContext.Movies.Count() > 0);
        }
    }
}
