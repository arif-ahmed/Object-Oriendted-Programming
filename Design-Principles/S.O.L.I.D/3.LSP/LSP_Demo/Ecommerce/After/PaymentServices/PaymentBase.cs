namespace Ecommerce.After.PaymentServices
{
    public abstract class PaymentBase
    {
        public abstract bool Refund(decimal amount, string transactionId);
    }
}
