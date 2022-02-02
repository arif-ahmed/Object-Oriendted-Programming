using InfluencerManager;
using Infrastructure.Contracts;

namespace ServiceProvider
{
    public class CommandParser : ICommandParser
    {
        private List<ICommand> _commands;

        public CommandParser(List<ICommand> commands) 
        {
            _commands = commands;
        }

        public ICommand Parse(string input)
        {
            string[] inputParts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (inputParts.Length == 0)
            {
                throw new ArgumentException(string.Format("invalid command."));
            }

            string commandType = inputParts[0];

            ICommand command = commandType switch
            {
                "Test" => new TestCommand { Title = inputParts[1], Description = inputParts[2] },
                _ => throw new ArgumentException("invalid command.")
            };

            return command;
        }
    }
}
