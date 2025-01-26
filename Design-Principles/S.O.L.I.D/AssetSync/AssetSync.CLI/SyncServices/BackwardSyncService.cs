using AssetSync.CLI.Contracts;
using AssetSync.CLI.SyncServices.Contracts;

namespace AssetSync.CLI.SyncServices
{
    public class BackwardSyncService : ISyncService
    {
        private readonly IBrandshareDAMService _brandshareDAMService;
        private readonly IDriveManager _driveManager;

        public BackwardSyncService(IBrandshareDAMService brandshareDAMService, IDriveManager driveManager)
        {
            _brandshareDAMService = brandshareDAMService;
            _driveManager = driveManager;
        }

        public async Task RunAsync()
        {
            List<string> folders = await _brandshareDAMService.GetFolders("<job-id>");
            foreach (string folder in folders) 
            {
                await _driveManager.CreateFolder(folder);
                List<string> files = await _brandshareDAMService.GetItems(folder);

                foreach (string file in files) 
                {
                    await _driveManager.CreateFile(string.Empty, file);
                }
            }
        }
    }
}
