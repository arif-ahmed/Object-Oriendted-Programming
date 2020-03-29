namespace SRP.Ecommerce.After.Contracts
{
    using System.Collections.Generic;
    public interface IShoppingCart
    {
        public decimal TotalAmount { get; }
        public IEnumerable<IOrderItem> Items { get; set; }
        public string CustomerEmail { get; set; }
    }
}
