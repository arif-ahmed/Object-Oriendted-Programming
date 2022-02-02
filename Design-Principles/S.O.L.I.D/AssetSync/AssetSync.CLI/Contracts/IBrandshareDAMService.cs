

namespace AssetSync.CLI.Contracts
{
    public interface IBrandshareDAMService
    {
        //int GetMachineInterval();

        //SyncJobModel GetSyncJobById(string syncJobId);

        //List<SyncJobDTO> GetSyncJobList();

        //string IsDamFolderExists(string jobId, string folderPath);

        //string CreateDamFolder(string jobId, string parentFolderId, string folderName);

        //GetUploadDetailsResponse GetUploadDetails(SyncJob syncJob, FileInfo file);

        //GetUploadDetailsResponse GetUploadDetailsForFileReplacement(string itemId);

        //bool CheckFileExists(string jobId, string filePath, string destinationPath, string volumePath);

        //CreateItemResponse CreateItem(DamItem damItem);

        //string GetS3Info();

        //S3Config GetS3Info2();

        //ResponseModel DeleteDamFolder(string jobId, string folderId, string folderName);

        //ResponseModel DeleteItem(string jobId, string itemId);

        //ResponseModel RenameFile(string itemId, string fileName);

        //ResponseModel RenameFolder(string jobId, string folderId, string newFolderName);

        //ResponseModel MoveFolder(string jobId, string currentFolderId, string parentFolderId);

        //ResponseModel MoveFile(string itemId, string targetFolderId);

        //ResponseModel ReplaceAsset(string jobId, string itemId);

        //List<MarcomboxDirectoryResponse> GetFolders(string syncJobId);

        //string GetFileItems(string jobId, bool isActive, string folderId, string lastItemId, int pageSize, long modifiedAfterAt);

        //string GetFileInfo(string jobId, string volumeName, bool isActive, string lastItemId, int pageSize, long lastRun);

        //S3Config GetS3Config();

        //GetUploadDetailsResponse GetUploadDetails(
        //    string syncJobId,
        //    string localBaseDirectoryPath,
        //    string marcomboxBaseDirectoryPath,
        //    string filePath,
        //    string fileName
        //);

        //void UpdateJobInfo(
        //    string syncJobId,
        //    string destinationPath,
        //    int jobInterval,
        //    string jobStatus,
        //    int affectedFolders,
        //    int affectedFiles
        //);

        Task<bool> TestConnection();
        Task<bool> CreateFolder(string name);
        Task<bool> CreateItem(string name);

        //MarcomboxFilesAndFoldersCount GetMarcomboxFilesAndFoldersCount(string syncJobId);

        //string CheckIfLocalFileExistInMarcombox(ISyncJob syncJob, string filePath);

        Task<List<string>> GetFolders(string jobId);
        Task<List<string>> GetItems(string jobId);

    }
}
