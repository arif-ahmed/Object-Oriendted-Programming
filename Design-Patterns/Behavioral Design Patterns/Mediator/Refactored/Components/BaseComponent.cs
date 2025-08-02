using Mediator.Violation.Interfaces;

namespace Mediator.Refactored.Components;

public abstract class BaseComponent<TArgs> : IUIComponent<TArgs> where TArgs : EventArgs
{
    public bool? IsVisiable { get; set; }
    public IMediator Mediator { get; set; }

    public BaseComponent(IMediator mediator)
    {
        Mediator = mediator;
    }


    public event EventHandler<TArgs>? Event;
    protected abstract void OnEvent(TArgs args);
    public abstract void Render();
    protected void RaiseEvent(TArgs args)
    {
        Event?.Invoke(this, args);
        Mediator.Notify(this, args);

    }
}
