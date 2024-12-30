
using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public class BrandshareDAM : IIntegrationComponent
    {
        private IBrandshareDAMService _brandshareDAMService;

        public BrandshareDAM(IBrandshareDAMService brandshareDAMService) 
        {
            _brandshareDAMService = brandshareDAMService;
        }
    }
}
