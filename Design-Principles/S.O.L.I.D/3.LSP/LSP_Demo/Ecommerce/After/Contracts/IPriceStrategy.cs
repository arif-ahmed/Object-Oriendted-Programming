namespace Ecommerce.After.Contracts
{
    public interface IPriceStrategy
    {
        bool IsMatch(IOrderItem item);
        decimal CalculatePrice(IOrderItem item);
    }
}
