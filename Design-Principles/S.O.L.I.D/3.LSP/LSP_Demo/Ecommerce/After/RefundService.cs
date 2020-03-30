namespace Ecommerce.After
{
    using PaymentServices;
    public class RefundService
    {
        public bool Refund(PaymentServiceType paymentServiceType, PaymentInformation paymentInformation, decimal amount, string transactionId)
        {
            PaymentBase payment = PaymentFactory.GetPaymentService(paymentServiceType, paymentInformation);
            payment.Refund(amount, transactionId);

            bool serviceResponse = payment.Refund(amount, transactionId);
            return serviceResponse;
        }
    }
}
