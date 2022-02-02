
using Infrastructure.Contracts;

namespace InfluencerManager
{
    public class TestCommandHandler : ICommandHandler
    {
        public bool CanHandle(ICommand command) => command is TestCommand;
        public string Handle(ICommand command)
        {
            if (command is not TestCommand testCommand) 
            {
                throw new ArgumentException("command is not TestCommand");
            }

            return string.Format("{0} => Title: {1}, Description: {2}", testCommand.Name, testCommand.Title, testCommand.Description);
        }
    }
}
