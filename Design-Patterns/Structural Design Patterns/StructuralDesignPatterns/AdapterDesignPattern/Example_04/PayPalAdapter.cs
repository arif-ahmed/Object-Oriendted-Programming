
namespace AdapterDesignPattern.Example_04
{
    public class PayPalAdapter : IPaymentAdapter
    {
        private readonly IPayPalPayment _payPalPayment;

        public PayPalAdapter(IPayPalPayment payPalPayment)
        {
            _payPalPayment = payPalPayment;
        }

        public string Pay(decimal amount)
        {
            return _payPalPayment.MakePayment(amount);
        }
    }
}
