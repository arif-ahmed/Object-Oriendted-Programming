using OrderProcessing.Follow.Contracts;

namespace OrderProcessing.Follow
{
    public class UKTaxStrategy : ITaxStrategy
    {
        public decimal FindTaxAmount(Order order)
        {
            return 0.10M;
        }
    }
}
