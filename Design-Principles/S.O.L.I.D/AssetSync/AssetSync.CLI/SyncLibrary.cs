
using AssetSync.CLI.Contracts;
using AssetSync.CLI.Implementations;

namespace AssetSync.CLI
{
    public class SyncLibrary
    {
        // Lazy<T> ensures the instance is created in a thread-safe and lazy manner
        private static readonly Lazy<SyncLibrary> _lazyInstance = new(() => new SyncLibrary());


        public List<ISyncService> SyncServices { get; set; } = new List<ISyncService> 
        {
            new FileToDAMSyncService(new MachineFileSystem(new Downloader()), new BrandshareDAM(new BrandshareDAMService(), new S3BucketUploader())) 
        };

        // Private constructor to prevent direct instantiation
        private SyncLibrary()
        {
        }

        // Property to access the Singleton instance
        public static SyncLibrary Instance => _lazyInstance.Value;

        // Example method
        public async Task RunAsync()
        {
            SyncServices.ForEach(async syncService => await syncService.StartAsync());
            await Task.CompletedTask;
        }
    }

}
