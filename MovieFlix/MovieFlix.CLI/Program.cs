using MovieFlix.FakeDataStore;
using MovieFlix.Manager;
using MovieFlix.Manager.Contracts;
using MovieFlix.Models;
using MovieFlix.Repositories;
using MovieFlix.Repositories.Contracts;

namespace MovieFlix.CLI
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            FakeDbContext fakeDbContext = new FakeDbContext();
            IRepository<User> userRepository = new UserRepository(fakeDbContext);
            IRepository<Movie> movieRepository = new MovieRepository(fakeDbContext);

            IMovieManager movieManager = new MovieManager(movieRepository);
            IUserManager userManager = new UserManager(movieRepository, userRepository);

            await userManager.InsertUser(new User(1, "Arif Ahmed"));
            await userManager.InsertUser(new User(1, "Atiqur Rahman"));

            await userManager.AddMovieToWatchList(1, 1);
            await userManager.AddMovieToWatchList(1, 2);

            await userManager.GetRecommendedMovies(1);

        }
    }
}
