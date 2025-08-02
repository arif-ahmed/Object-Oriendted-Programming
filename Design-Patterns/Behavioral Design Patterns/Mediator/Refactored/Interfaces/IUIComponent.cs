namespace Mediator.Refactored.Interfaces;
public interface IUIComponent<TArgs> where TArgs : EventArgs
{
    event EventHandler<TArgs>? Event;
}
