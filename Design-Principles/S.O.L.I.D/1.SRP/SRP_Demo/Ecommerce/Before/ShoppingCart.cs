namespace SRP.Ecommerce.Before
{
    using System.Linq;
    using System.Collections.Generic;
    public class ShoppingCart
    {
        public decimal TotalAmount 
        {
            get
            {
                decimal totalAmount = 0;

                foreach (var item in Items)
                {
                    totalAmount += item.Quantity * item.Sku;
                }

                return totalAmount;
            }
        }
        public IEnumerable<OrderItem> Items { get; set; }
        public string CustomerEmail { get; set; }
    }
}
