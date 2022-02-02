namespace AssetSync.CLI.Contracts
{
    public interface IFileSystemService
    {
        bool Exist(string path);
        List<string> GetFolders(string path);
        List<string> GetFiles(string path);
    }
}
