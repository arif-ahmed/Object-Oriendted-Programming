using AssetSync.CLI.Contracts;
using AssetSync.CLI.Implementations;
using Moq;

namespace AssetSync.Tests
{
    public class DriveManagerTests
    {
        private readonly Mock<IUploader> _uploaderMock;
        private readonly Mock<DriveManager> _driveManagerMock;
        public DriveManagerTests()
        {
            _uploaderMock = new Mock<IUploader>();
            _driveManagerMock = new Mock<DriveManager>(_uploaderMock.Object);

            _uploaderMock.Setup(uploader => uploader.UploadFile(It.IsAny<string>())).ReturnsAsync(true);
        }

        [Fact]
        public async Task Test_DriveManager_CreateFile()
        {
            var result = await _driveManagerMock.Object.CreateFile(It.IsAny<string>(), It.IsAny<string>());
            Assert.True(result);
        }
    }
}
