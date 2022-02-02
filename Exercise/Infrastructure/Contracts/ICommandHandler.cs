namespace Infrastructure.Contracts
{
    public interface ICommandHandler
    {
        bool CanHandle(ICommand command);
        string Handle(ICommand command);
    }
}
