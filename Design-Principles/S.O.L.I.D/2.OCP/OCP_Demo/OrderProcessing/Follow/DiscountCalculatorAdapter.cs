using OrderProcessing.Follow.Contracts;

namespace OrderProcessing.Follow
{
    public class DiscountCalculatorAdapter : IDiscountCalculator
    {
        public decimal CalculateDiscount(Order order)
        {
            return DiscountCalculator.CalculateDiscount(order);
        }
    }
}
