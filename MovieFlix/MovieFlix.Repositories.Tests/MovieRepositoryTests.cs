using Moq;
using MovieFlix.Models;
using MovieFlix.Repositories.Contracts;
using MovieFlix.Utilities;

namespace MovieFlix.Repositories.Tests
{
    public class MovieRepositoryTests
    {
        private Mock<IRepository<Movie>> _repository;

        public MovieRepositoryTests() 
        {
            _repository = new Mock<IRepository<Movie>>();
            _repository.Setup(repo => repo.Insert(It.IsAny<Movie>()));
        }

        [Fact]
        public void Should_not_exist() 
        {
            _repository.Object.Insert(new Movie(1, "A", "A", Genre.Drama));
        }
    }
}
