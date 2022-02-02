using Mediator.Violation.Components;

namespace Mediator.Violation.Interfaces;
public interface IUIComponent<TArgs> where TArgs : EventArgs
{
    event EventHandler<TArgs>? Event;
}
