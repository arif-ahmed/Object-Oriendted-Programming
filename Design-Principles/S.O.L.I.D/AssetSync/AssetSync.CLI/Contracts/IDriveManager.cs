namespace AssetSync.CLI.Contracts
{
    public interface IDriveManager
    {
        Task<bool> CreateFolder(string path);
        Task<bool> CreateFile(string fileKey, string filePath);
    }
}
