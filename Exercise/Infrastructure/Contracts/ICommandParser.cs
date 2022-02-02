namespace Infrastructure.Contracts
{
    public interface ICommandParser
    {
        ICommand Parse(string input);
    }
}
