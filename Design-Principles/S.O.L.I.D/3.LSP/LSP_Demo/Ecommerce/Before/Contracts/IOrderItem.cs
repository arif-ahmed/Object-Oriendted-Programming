namespace Ecommerce.Before.Contracts
{
    public interface IOrderItem
    {
        public string Identifier { get; set; }
        public int Sku { get; set; }
        public int Quantity { get; set; }
    }
}
