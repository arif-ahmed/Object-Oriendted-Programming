namespace Ecommerce.Before.Contracts
{
    public interface IPriceCalculator
    {
        decimal CalculatePrice(IOrderItem item);
    }
}
