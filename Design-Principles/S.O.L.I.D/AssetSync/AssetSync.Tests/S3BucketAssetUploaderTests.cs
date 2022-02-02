using AssetSync.CLI.Contracts;
using AssetSync.CLI.Implementations;
using Moq;

namespace AssetSync.Tests
{
    public class S3BucketAssetUploaderTests
    {
        public S3BucketAssetUploaderTests() 
        {

        }

        [Fact]
        public async Task Test_IfFileUploadedIntoS3Bucket()
        {
            IUploader uploader = new S3BucketAssetUploader();
            
            string fileKey = string.Empty;
            bool isFileUploaded = await uploader.UploadFile(fileKey);
            Assert.True(isFileUploaded);
        }
    }
}
