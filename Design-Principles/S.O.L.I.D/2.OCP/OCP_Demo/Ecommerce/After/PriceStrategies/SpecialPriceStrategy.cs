namespace Ecommerce.After.PriceStrategies
{
    using Contracts;
    public class SpecialPriceStrategy : IPriceStrategy
    {
        public bool IsMatch(IOrderItem item)
        {
            return item.Identifier.StartsWith("Spec");
        }

        public decimal CalculatePrice(IOrderItem item)
        {
            decimal total = 0m;
            total += item.Quantity * .3m;
            int setsOfFour = item.Quantity / 4;
            total -= setsOfFour * .15m;
            return total;
        }
    }
}
