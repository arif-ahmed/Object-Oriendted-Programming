using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("🔄 === Mediator Pattern Example ===\n");

var dialog = new Mediator.Refactored.Dialogs.ProfileDialog();
dialog.Show();

Console.WriteLine("Press any key to continue");
Console.ReadLine();

