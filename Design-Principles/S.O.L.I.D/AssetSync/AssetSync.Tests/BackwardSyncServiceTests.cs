using AssetSync.CLI.Contracts;
using AssetSync.CLI.SyncServices;
using Moq;

namespace AssetSync.Tests
{
    public class BackwardSyncServiceTests
    {
        private readonly Mock<IBrandshareDAMService> _mockBrandshareDAMService;
        private readonly Mock<IDriveManager> _mockDriveManager;
        private readonly BackwardSyncService _backwardSyncService;

        public BackwardSyncServiceTests()
        {
            _mockBrandshareDAMService = new Mock<IBrandshareDAMService>();
            _mockDriveManager = new Mock<IDriveManager>();
            _backwardSyncService = new BackwardSyncService(_mockBrandshareDAMService.Object, _mockDriveManager.Object);
        }

        [Fact]
        public async Task RunAsync_SuccessfulExecution_CreatesFoldersAndFiles()
        {
            // Arrange
            var folders = new List<string> { "Folder1", "Folder2" };
            var files = new List<string> { "File1", "File2" };

            _mockBrandshareDAMService
                .Setup(service => service.GetFolders(It.IsAny<string>()))
                .ReturnsAsync(folders);

            _mockBrandshareDAMService
                .Setup(service => service.GetItems(It.IsAny<string>()))
                .ReturnsAsync(files);

            // Act
            await _backwardSyncService.RunAsync();

            // Assert
            foreach (var folder in folders)
            {
                _mockDriveManager.Verify(manager => manager.CreateFolder(folder));
            }

            foreach (var file in files)
            {
                _mockDriveManager.Verify(manager => manager.CreateFile(string.Empty, file));
            }
        }
    }
}
