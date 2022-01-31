namespace Ecommerce.Before.Contracts
{
    public interface IPriceStrategy
    {
        bool IsMatch(IOrderItem item);
        decimal CalculatePrice(IOrderItem item);
    }
}
