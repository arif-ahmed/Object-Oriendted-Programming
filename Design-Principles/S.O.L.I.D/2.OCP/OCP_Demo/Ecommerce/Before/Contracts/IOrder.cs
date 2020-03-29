namespace Ecommerce.Before.Contracts
{
    public interface IOrder
    {
        IShoppingCart ShoppingCart { get; }
        void Checkout();
    }
}
