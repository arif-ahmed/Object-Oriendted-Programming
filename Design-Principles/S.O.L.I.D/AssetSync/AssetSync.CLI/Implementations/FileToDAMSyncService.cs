


namespace AssetSync.CLI.Implementations
{
    public class FileToDAMSyncService : SyncJobService<MachineFileSystem, BrandshareDAM>
    {
        public FileToDAMSyncService(MachineFileSystem source, BrandshareDAM target) : base(source, target) { }
        
        protected override async Task ImplementSync()
        {
            var isConnected = await _target.TestConnection();

            Console.WriteLine($"{typeof(FileToDAMSyncService).Name} Running: {isConnected}");
            await Task.CompletedTask;
        }
    }
}
