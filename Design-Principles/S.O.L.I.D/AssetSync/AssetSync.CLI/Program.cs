
using AssetSync.CLI;

SyncLibrary syncLibrary = SyncLibrary.Instance;
await syncLibrary.RunAsync();

Console.ReadKey();