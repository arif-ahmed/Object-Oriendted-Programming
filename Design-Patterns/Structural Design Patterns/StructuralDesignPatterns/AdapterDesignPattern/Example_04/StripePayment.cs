namespace AdapterDesignPattern.Example_04
{
    public class StripePayment : IStripePayment
    {
        public string ProcessPayment(decimal amount)
        {
            // Simulate processing a payment via Stripe
            return $"Paid {amount} using Stripe";
        }
    }
}
