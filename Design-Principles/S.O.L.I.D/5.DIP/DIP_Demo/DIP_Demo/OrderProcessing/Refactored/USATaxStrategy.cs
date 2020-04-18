namespace DIP_Demo.OrderProcessing.Refactored
{
    using Contracts;
    public class USATaxStrategy : ITaxStrategy
    {
        public string Identifier { get; } = "USA";

        public decimal FindTaxAmount()
        {
            return 10.0m;
        }
    }
}
