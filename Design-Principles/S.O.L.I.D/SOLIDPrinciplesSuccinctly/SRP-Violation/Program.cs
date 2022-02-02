namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            ISyncOperation syncOperation = new SyncOperation();
            syncOperation.Connect("Server-1");
            syncOperation.Sync();
            syncOperation.Store();
            syncOperation.Save();

        }
    }
}
