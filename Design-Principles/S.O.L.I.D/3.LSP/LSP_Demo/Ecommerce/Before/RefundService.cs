namespace Ecommerce.Before
{
    using PaymentServices;
    public class RefundService
    {
        public bool Refund(PaymentServiceType paymentServiceType, decimal amount, string transactionId)
        {
            bool refundSuccess = false;
            PaymentBase payment = PaymentFactory.GetPaymentService(paymentServiceType);
            if ((payment as PayPalPayment) != null)
            {
                ((PayPalPayment)payment).AccountName = "Andras";
                ((PayPalPayment)payment).Password = "Passw0rd";
            }
            else if ((payment as WorldPayPayment) != null)
            {
                ((WorldPayPayment)payment).AccountName = "Andras";
                ((WorldPayPayment)payment).Password = "Passw0rd";
                ((WorldPayPayment)payment).ProductId = "ABC";
            }

            string serviceResponse = payment.Refund(amount, transactionId);

            if (serviceResponse.Contains("Auth") || serviceResponse.Contains("Success"))
            {
                refundSuccess = true;
            }

            return refundSuccess;
        }
    }
}
