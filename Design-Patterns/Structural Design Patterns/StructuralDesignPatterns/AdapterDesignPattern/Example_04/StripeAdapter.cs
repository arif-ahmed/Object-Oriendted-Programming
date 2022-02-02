
namespace AdapterDesignPattern.Example_04
{
    public class StripeAdapter : IPaymentAdapter
    {
        private readonly IStripePayment _stripePayment;

        public StripeAdapter(IStripePayment stripePayment)
        {
            _stripePayment = stripePayment;
        }

        public string Pay(decimal amount)
        {
            return _stripePayment.ProcessPayment(amount);
        }
    }
}
