namespace Ecommerce.After.Contracts
{
    public interface IPriceCalculator
    {
        decimal CalculatePrice(IOrderItem item);
    }
}
