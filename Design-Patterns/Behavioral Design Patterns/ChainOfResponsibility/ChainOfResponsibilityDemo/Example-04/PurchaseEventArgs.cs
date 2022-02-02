

namespace ChainOfResponsibilityDemo.Example_04
{
    public class PurchaseEventArgs : EventArgs
    {
        internal Purchase Purchase { get; init; } = null!;
    }
}
