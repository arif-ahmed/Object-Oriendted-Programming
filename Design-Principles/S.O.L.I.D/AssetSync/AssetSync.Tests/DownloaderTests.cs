using AssetSync.CLI.Contracts;
using Moq;

namespace AssetSync.Tests
{
    public class DownloaderTests
    {
        private readonly Mock<IDownloader> _downloaderMock;
        public DownloaderTests() 
        {
            _downloaderMock = new Mock<IDownloader>();
            _downloaderMock.Setup(downloaderMock => downloaderMock.DownlaodAsync(It.IsAny<string>())).ReturnsAsync(true);
        }

        [Theory]
        [InlineData("")]
        public async Task Test_DownloadWithValidDownloadLink(string downloadLink)
        {
            bool actual = await _downloaderMock.Object.DownlaodAsync(downloadLink);
            Assert.True(actual);
        }
    }
}
