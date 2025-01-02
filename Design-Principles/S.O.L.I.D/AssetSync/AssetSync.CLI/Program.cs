
using AssetSync.CLI;
using System.Diagnostics;

SyncLibrary syncLibrary = SyncLibrary.Instance;
await syncLibrary.RunAsync();

Console.ReadKey();