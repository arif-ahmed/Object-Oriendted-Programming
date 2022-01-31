namespace Ecommerce.After.Contracts
{
    public interface IPaymentService
    {
        void ProcessCreditCard(IPaymentDetails paymentDetails, decimal totalAmount);
    }
}
