using OrderProcessing.Follow.Contracts;

namespace OrderProcessing.Follow
{
    public class OrderProcessor
    {
        private readonly IDiscountCalculator _discountCalculator;
        private readonly ITaxStrategy _taxStrategy;

        public OrderProcessor(IDiscountCalculator discountCalculator, ITaxStrategy taxStrategy)
        {
            this._discountCalculator = discountCalculator;
            this._taxStrategy = taxStrategy;
        }

        public decimal CalculateTotal(Order order)
        {
            decimal itemTotal = order.GetItemTotal();
            decimal discountAmount = _discountCalculator.CalculateDiscount(order);
            decimal taxAmount = _taxStrategy.FindTaxAmount(order);
            decimal total = itemTotal - discountAmount + taxAmount;
            return total;
        }
    }
}