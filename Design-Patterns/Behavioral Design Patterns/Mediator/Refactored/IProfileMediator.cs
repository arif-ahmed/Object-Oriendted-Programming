using Mediator.Violation.Interfaces;

namespace Mediator.Refactored;
public interface IProfileMediator
{
    void Notify(IUIComponent<EventArgs> sender, EventArgs args);
}
