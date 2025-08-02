using Mediator.Refactored.Interfaces;

namespace Mediator.Refactored;
public interface IMediator
{
    void Notify(object sender, EventArgs args);
}
