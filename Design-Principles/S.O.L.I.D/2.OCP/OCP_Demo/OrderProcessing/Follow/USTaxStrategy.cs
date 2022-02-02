using OrderProcessing.Follow.Contracts;

namespace OrderProcessing.Follow
{
    public class USTaxStrategy : ITaxStrategy
    {
        public decimal FindTaxAmount(Order order)
        {
            return 0.10M;
        }
    }
}
