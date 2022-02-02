using AssetSync.CLI.Contracts;
using AssetSync.CLI.Implementations;
using Moq;

namespace AssetSync.Tests
{
    public class BrandshareDAMServiceTests
    {
        private readonly Mock<IBrandshareDAMService> brandshareDAMServiceMock;
        public BrandshareDAMServiceTests()
        {
            brandshareDAMServiceMock = new Mock<IBrandshareDAMService>();
            brandshareDAMServiceMock.Setup(mock => mock.GetFolders(It.IsAny<string>())).ReturnsAsync(new List<string>() { "A" });
            brandshareDAMServiceMock.Setup(mock => mock.GetItems(It.IsAny<string>())).ReturnsAsync(new List<string>() { "A" });
        }

        [Fact]
        public async Task Test_IfBrandshareDAMIsAlive()
        {
            BrandshareDAMService service = new BrandshareDAMService();
            bool isAlive = await service.TestConnection();
            Assert.True(isAlive);
        }

        [Theory]
        [InlineData("1")]
        public async Task Test_GetBrandshareDAMFolders(string jobId)
        {
            List<string> expected = new List<string>() { "A" };
            List<string> actual = await brandshareDAMServiceMock.Object.GetFolders(jobId);
            Assert.Equal(expected.Count, actual.Count);
        }

        [Theory]
        [InlineData("1")]
        public async Task Test_GetBrandshareDAMItems(string jobId)
        {
            List<string> expected = new List<string>() { "A" };
            List<string> actual = await brandshareDAMServiceMock.Object.GetItems(jobId);
            Assert.Equal(expected.Count, actual.Count);
        }
    }
}
