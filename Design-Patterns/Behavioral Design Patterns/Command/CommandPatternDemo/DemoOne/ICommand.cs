namespace CommandPatternDemo.DemoOne
{
    public interface ICommand
    {
        void ExecuteAction();
        void UndoAction();
    }
}
