namespace SRP.Ecommerce.After
{
    using System.Collections.Generic;
    using Contracts;
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
        public IEnumerable<IOrderItem> Items { get; set; }
        public string CustomerEmail { get; set; }
    }
}
