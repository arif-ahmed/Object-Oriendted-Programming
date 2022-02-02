using AssetSync.CLI.Models;
using AssetSync.CLI.Repositories.Contracts;
using Moq;

namespace AssetSync.Tests
{
    public class LocalRepositoryTests
    {
        private Mock<IRepository<LocalFolder>> _repositoryMock;
        public LocalRepositoryTests()
        {
            _repositoryMock = new Mock<IRepository<LocalFolder>>();
            _repositoryMock.Setup(m => m.Search(x => x.Path == "A")).ReturnsAsync(GetLocalFolders());
        }

        private IQueryable<LocalFolder> GetLocalFolders() => new List<LocalFolder> { }.AsQueryable();
    
    }
}
