using AssetSync.CLI.Contracts;

namespace AssetSync.CLI.Implementations
{
    public class FileToDAMSyncService : SyncJobService<MachineFileSystem, BrandshareDAM>
    {
        public FileToDAMSyncService(MachineFileSystem source, BrandshareDAM target) : base(source, target) { }
        
        protected override async Task ImplementSync()
        {
            /**
             * read source directory
             * read files of current directory
             * 
            **/

            bool exist = source.Exist("");

            if (!exist) 
            {
                return;
            }




            //var isConnected = await target.TestConnection();

            Console.WriteLine($"{typeof(FileToDAMSyncService).Name} Running");
            await Task.CompletedTask;
        }
    }
}
