using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public class DriveManager : IDriveManager
    {
        private readonly IUploader _uploader;
        public DriveManager(IUploader uploader) 
        {
            _uploader = uploader ?? throw new ArgumentNullException("");
        }

        public async Task<bool> CreateFile(string fileKey, string filePath)
        {
            var result = await _uploader.UploadFile(fileKey);
            
            return await Task.FromResult(result);
        }

        public async Task<bool> CreateFolder(string path)
        {
            return await Task.FromResult(true);
        }
    }
}
