namespace Ecommerce.Before.Contracts
{
    public interface IPaymentService
    {
        void ProcessCreditCard(IPaymentDetails paymentDetails, decimal totalAmount);
    }
}
