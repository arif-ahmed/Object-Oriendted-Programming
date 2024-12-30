
using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public class MachineFileSystem : IIntegrationComponent, IFileSystemService
    {
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
