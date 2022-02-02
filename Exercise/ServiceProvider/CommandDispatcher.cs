using Infrastructure.Contracts;

namespace ServiceProvider
{
    public class CommandDispatcher : ICommanDispatcher
    {
        private readonly List<ICommandHandler> _handlers = new();

        public CommandDispatcher(List<ICommandHandler> handlers) 
        {
            if(handlers == null)
            {
                throw new ArgumentException("handlers null");
            }

            _handlers = handlers;
        }

        public ICommandHandler Dispatch(ICommand command)
        {
            if (command == null) 
            {
                throw new ArgumentNullException("command argument can not be null");
            }

            ICommandHandler handler = _handlers.FirstOrDefault(handler => handler.CanHandle(command));

            if (handler == null) 
            {
                throw new InvalidOperationException(string.Format("No handlers found."));
            };

            return handler;
        }
    }
}
