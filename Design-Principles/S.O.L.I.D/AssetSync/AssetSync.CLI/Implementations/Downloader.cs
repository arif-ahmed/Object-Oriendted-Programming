
using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public class Downloader : IDownloader
    {
        public async Task DownlaodAsync()
        {
            await Task.CompletedTask;
        }
    }
}
