namespace AdapterDesignPattern.Example_04
{
    public class PayPalPayment : IPayPalPayment
    {
        public string MakePayment(decimal amount)
        {
            // Simulate making a payment via PayPal
            return $"Paid {amount} using PayPal";
        }
    }
}
