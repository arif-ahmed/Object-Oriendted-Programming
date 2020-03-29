namespace Ecommerce.After.PriceStrategies
{
    using Contracts;

    public class PricePerUnitStrategy : IPriceStrategy
    {
        public decimal CalculatePrice(IOrderItem item)
        {
            return item.Quantity * 4m;
        }

        public bool IsMatch(IOrderItem item)
        {
            return item.Identifier.StartsWith("Each");
        }
    }
}
