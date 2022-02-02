using InfluencerManager;
using Infrastructure.Contracts;

namespace ServiceProvider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter commands (type 'exit' to quit):");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input?.ToLower() == "exit")
                    break;

                try
                {
                    List<ICommand> commands = new List<ICommand>() { new TestCommand() };
                    ICommandParser parser = new CommandParser(commands);
                    ICommand command = parser.Parse(input);

                    List<ICommandHandler> handlers = new List<ICommandHandler>() { new TestCommandHandler() };
                    CommandDispatcher commanHandlerDispatcher = new CommandDispatcher(handlers);
                    ICommandHandler handler = commanHandlerDispatcher.Dispatch(command);

                    string result = handler.Handle(command);
                    Console.WriteLine($"Output: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
