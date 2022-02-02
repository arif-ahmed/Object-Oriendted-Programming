using Moq;
using MovieFlix.FakeDataStore;
using MovieFlix.Manager.Contracts;
using MovieFlix.Models;
using MovieFlix.Repositories;
using MovieFlix.Utilities;

namespace MovieFlix.Manager.Tests
{
    public class UserManagerTests
    {
        //private readonly FakeDbContext _dbContext = FakeDbContext.Instance;
        //private readonly Mock<IUserManager> _userManagerMock;
        //private readonly UserManager _userManager;
        //private readonly MovieManager _movieManager;

        public UserManagerTests()
        {
            //_userManagerMock = new Mock<IUserManager>();
            //_userManagerMock.Setup(manager => manager.AddMovieToWatchList(1, 1));

            //_userManager = new UserManager(new MovieRepository(_dbContext), new UserRepository(_dbContext));
            //_movieManager = new MovieManager(new MovieRepository(_dbContext));
        }

        [Fact]
        public async Task Test_User_CAN_ADD_MOVIE_TO_WATCHLIST()
        {
            // Arrange
            FakeDbContext _dbContext = new FakeDbContext();
            UserManager _userManager = new UserManager(new MovieRepository(_dbContext), new UserRepository(_dbContext));
            MovieManager _movieManager = new MovieManager(new MovieRepository(_dbContext));
            await _movieManager.AddMovie(new Movie(1, "Iron Man", "Iron Man", Genre.Action));
            await _userManager.InsertUser(new User(1, "Arif Ahmed"));
            await _userManager.InsertUser(new User(2, "Atiqur Rahman"));
            await _userManager.InsertUser(new User(3, "Toukir Rahman"));

            // Act
            await _userManager.AddMovieToWatchHistory(1, 1, 5);
            await _userManager.AddMovieToWatchHistory(2, 1, 6);
            await _userManager.AddMovieToWatchHistory(3, 1, 9);

            Movie movie = await _movieManager.GetMovieById(1);

            // Assert
            Assert.Equal(6, movie.Rating);
        }

        [Fact]
        public async Task Test_User_GetRecommenedMovies()
        {
            FakeDbContext _dbContext = new FakeDbContext();
            UserManager _userManager = new UserManager(new MovieRepository(_dbContext), new UserRepository(_dbContext));
            MovieManager _movieManager = new MovieManager(new MovieRepository(_dbContext));

            await _movieManager.AddMovie(new Movie(1, "Inception", "A thief who steals corporate secrets through the use of dream-sharing technology.", Genre.ScienceFiction));
            await _movieManager.AddMovie(new Movie(2, "The Godfather", "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.", Genre.Drama));
            await _movieManager.AddMovie(new Movie(3, "The Dark Knight", "Batman faces the Joker, a criminal mastermind who wants to plunge Gotham City into anarchy.", Genre.Action));
            await _movieManager.AddMovie(new Movie(4, "Superbad", "Two co-dependent high school seniors are forced to deal with separation anxiety.", Genre.Comedy));
            await _movieManager.AddMovie(new Movie(5, "Get Out", "A young African-American visits his white girlfriend's parents for the weekend.", Genre.Horror));
            await _movieManager.AddMovie(new Movie(6, "Interstellar", "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans.", Genre.ScienceFiction));

            await _userManager.InsertUser(new User(1, "Arif Ahmed"));

            await _userManager.AddMovieToWatchList(1, 1);
            await _userManager.AddMovieToWatchList(1, 6);
            await _userManager.AddMovieToWatchHistory(1, 1, 5);

            List<Movie> recommendedMovies = await _userManager.GetRecommendedMovies(1);
        }
    }
}
