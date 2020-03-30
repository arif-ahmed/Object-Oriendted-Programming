namespace Ecommerce.After
{
    using System.Collections.Generic;
    using Contracts;
    public class ShoppingCart
    {
        private readonly IPriceCalculator _priceCalculator;
        public ShoppingCart(IPriceCalculator priceCalculator)
        {
            _priceCalculator = priceCalculator;
        }

        public decimal TotalAmount 
        {
            get
            {
                decimal totalAmount = 0;

                foreach (var item in Items)
                {
                    totalAmount += _priceCalculator.CalculatePrice(item);
                }

                return totalAmount;
            }
        }
        public IEnumerable<IOrderItem> Items { get; set; }
        public string CustomerEmail { get; set; }
    }
}
