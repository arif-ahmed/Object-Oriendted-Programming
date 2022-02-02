
using AssetSync.CLI.Repositories;

LocalFolderRepository repository = new LocalFolderRepository();

var folders = await repository.Search(x => x.Path == "A");

foreach (var folder in folders)
{
    Console.WriteLine(folder.Path);
}

Console.ReadKey();