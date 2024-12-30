using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public class BrandshareDAMService : IBrandshareDAMService
    {
        public async Task<bool> TestConnection()
        {
            return await Task.FromResult(true);
        }
    }
}
