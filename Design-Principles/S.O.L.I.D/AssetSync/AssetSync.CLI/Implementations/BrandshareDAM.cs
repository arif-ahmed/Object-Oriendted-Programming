
using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public class BrandshareDAM : IIntegrationComponent, IBrandshareDAMService
    {
        private IBrandshareDAMService _brandshareDAMService;

        public BrandshareDAM(IBrandshareDAMService brandshareDAMService) 
        {
            _brandshareDAMService = brandshareDAMService;
        }

        public async Task<bool> TestConnection()
        {
           return await _brandshareDAMService.TestConnection();
        }
    }
}
