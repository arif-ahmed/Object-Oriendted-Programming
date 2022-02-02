namespace Infrastructure.Contracts
{
    public interface ICommanDispatcher
    {
        ICommandHandler Dispatch(ICommand command);
    }
}
