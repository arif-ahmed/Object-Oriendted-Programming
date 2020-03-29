namespace Ecommerce.After
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
                    if (item.Identifier.StartsWith("Each"))
                    {
                        totalAmount += item.Quantity * 4m;
                    }
                    else if (item.Identifier.StartsWith("Weight"))
                    {
                        totalAmount += item.Quantity * 3m / 1000; //1 kilogram
                    }
                    else if (item.Identifier.StartsWith("Spec"))
                    {
                        totalAmount += item.Quantity * .3m;
                        int setsOfFour = item.Quantity / 4;
                        totalAmount -= setsOfFour * .15m; //discount on groups of 4 items
                    }
                }

                return totalAmount;
            }
        }
        public IEnumerable<IOrderItem> Items { get; set; }
        public string CustomerEmail { get; set; }
    }
}
