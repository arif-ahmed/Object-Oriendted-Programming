
using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public class BrandshareDAM : IIntegrationComponent, IBrandshareDAMService
    {
        private IBrandshareDAMService _brandshareDAMService;
        private IUploader _uploader;
        public BrandshareDAM(IBrandshareDAMService brandshareDAMService, IUploader uploader) 
        {
            _brandshareDAMService = brandshareDAMService;
            _uploader = uploader;
        }

        public async Task<bool> CreateFolder(string name)
        {
            return await _brandshareDAMService.CreateFolder(name);
        }

        public async Task<bool> CreateItem(string name)
        {
            _uploader.UploadFile(name);
            return await _brandshareDAMService.CreateItem(name);
        }

        public async Task<bool> TestConnection()
        {
           return await _brandshareDAMService.TestConnection();
        }
    }
}
