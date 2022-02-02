using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public class S3BucketAssetUploader : IUploader
    {
        public async Task<bool> UploadFile(string fileKey)
        {
            return await Task.FromResult(true);
        }
    }
}
