using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public class BrandshareDAMService : IBrandshareDAMService
    {
        public async Task<bool> TestConnection()
        {
            return await Task.FromResult(true);
        }

        public async Task<bool> CreateFolder(string name)
        {
            return await Task.FromResult(true);
        }

        public async Task<bool> CreateItem(string name)
        {
            return await Task.FromResult(true);
        }

        public async Task<List<string>> GetFolders(string jobId)
        {
            if (jobId == null) 
            {
                throw new ArgumentException("jobId cannot be null");
            }

            List<string> list = new List<string>();
            return await Task.FromResult(list); 
        }

        public async Task<List<string>> GetItems(string jobId)
        {
            List<string> list = new List<string>();
            return await Task.FromResult(list); 
        }
    }
}
