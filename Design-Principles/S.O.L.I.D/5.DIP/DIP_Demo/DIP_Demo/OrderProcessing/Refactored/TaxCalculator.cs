namespace DIP_Demo.OrderProcessing.Refactored
{
    using System.Linq;
    using System.Collections.Generic;
    using Refactored.Contracts;
    public class TaxCalculator
    {
        private List<ITaxStrategy> _taxStrategies;

        public TaxCalculator()
        {
            _taxStrategies.Add(new USATaxStrategy());
            _taxStrategies.Add(new UKTaxStrategy());
        }

        public decimal CalculateTax(Order order)
        {
            return _taxStrategies.Where(taxstrategy => taxstrategy.Identifier == order.Country).FirstOrDefault().FindTaxAmount();
        }
    }
}
