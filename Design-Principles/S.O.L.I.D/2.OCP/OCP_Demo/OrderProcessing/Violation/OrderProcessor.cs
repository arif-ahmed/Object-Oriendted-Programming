namespace OrderProcessing.Violation
{
    public class OrderProcessor
    {
        public decimal CalculateTotal(Order order)
        {
            decimal itemTotal = order.GetItemTotal();
            decimal discountAmount = DiscountCalculator.CalculateDiscount(order);
            decimal taxAmount = 0.0M;

            if (order.Country == "US")
            {
                taxAmount = FindTaxAmount(order);
            } 
            else if (order.Country == "UK") 
            {
                taxAmount = FindVatAmount(order);
            }

            decimal total = itemTotal - discountAmount + taxAmount;
            return total;
        }
        private decimal FindVatAmount(Order order)
        {
            // find the UK value added tax somehow
            return 10.0M;
        }

        private decimal FindTaxAmount(Order order)
        {
            // find the US tax somehow 
            return 10.0M;
        }
    }
}