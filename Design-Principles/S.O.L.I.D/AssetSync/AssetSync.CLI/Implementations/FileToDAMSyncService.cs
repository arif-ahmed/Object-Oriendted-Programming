using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public class FileToDAMSyncService : SyncJobService<MachineFileSystem, BrandshareDAM>
    {
        public FileToDAMSyncService(MachineFileSystem source, BrandshareDAM target) : base(source, target) { }
        
        protected override async Task ImplementSync()
        {
            bool exist = source.Exist("");

            if (!exist) 
            {
                return;
            }

            bool created = await target.CreateFolder("");
            var files = source.GetFiles("");

            foreach (var file in files) 
            {
                await target.CreateItem(file);
            }


            Console.WriteLine($"{typeof(FileToDAMSyncService).Name} Running");
            await Task.CompletedTask;
        }
    }
}
