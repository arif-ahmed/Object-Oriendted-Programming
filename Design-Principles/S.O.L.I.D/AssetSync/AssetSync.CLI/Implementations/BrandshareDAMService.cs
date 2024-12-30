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
    }
}
