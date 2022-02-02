
namespace AssetSync.CLI.Contracts
{
    public interface IUploader
    {
        Task<bool> UploadFile(string fileKey);
    }
}
