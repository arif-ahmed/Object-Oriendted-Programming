namespace AssetSync.CLI.Contracts
{
    public interface IDownloader
    {
        Task<bool> DownlaodAsync(string fileDownloadLink);
    }
}
