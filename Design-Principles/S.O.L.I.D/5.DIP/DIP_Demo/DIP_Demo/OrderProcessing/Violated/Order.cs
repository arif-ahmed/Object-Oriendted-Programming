
namespace DIP_Demo.OrderProcessing.Violated
{
    public class Order
    {
        public string Country { get; set; }

        public decimal GetItemTotal()
        {
            return 100.0m;
        }
    }
}
