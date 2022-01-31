namespace Ecommerce.Before.Contracts
{
    public interface INotificationService
    {
        void NotifyCustomerOrderCreated(string customerEmail);
    }
}
