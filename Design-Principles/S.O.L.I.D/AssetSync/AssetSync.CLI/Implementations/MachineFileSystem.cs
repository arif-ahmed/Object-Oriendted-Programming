
using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public class MachineFileSystem : IIntegrationComponent, IFileSystemService
    {
        private IDownloader _downloader;

        public MachineFileSystem(IDownloader downloader)
        {
            _downloader = downloader;
        }

        public bool Exist(string path)
        {
            return true;
        }

        public List<string> GetFiles(string path)
        {
            return new List<string>();
        }

        public List<string> GetFolders(string path)
        {
            return new List<string>();
        }
    }
}
