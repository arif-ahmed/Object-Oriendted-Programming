namespace SRP.Ecommerce.After.Contracts
{
    public interface INotificationService
    {
        void NotifyCustomerOrderCreated(string customerEmail);
    }
}
