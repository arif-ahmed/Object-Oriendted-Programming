
namespace AdapterDesignPattern.Example_04
{
    // Stripe Gateway
    public interface IStripePayment
    {
        string ProcessPayment(decimal amount);
    }
}
