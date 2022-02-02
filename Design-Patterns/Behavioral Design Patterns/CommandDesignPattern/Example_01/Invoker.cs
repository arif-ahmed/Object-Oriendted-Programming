namespace CommandDesignPattern.Example_01
{
    public class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command) => _command = command;

    }
}
