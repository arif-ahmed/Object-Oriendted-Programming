namespace Ecommerce.After
{
    using System.Linq;
    using System.Collections.Generic;

    using Contracts;
    using PriceStrategies;
    public class DefaultPriceCalculator : IPriceCalculator
    {
        private readonly IEnumerable<IPriceStrategy> _pricingRules;

        public DefaultPriceCalculator(IEnumerable<IPriceStrategy> priceStrategies)
        {
            _pricingRules = priceStrategies;
        }

        public decimal CalculatePrice(IOrderItem item)
        {
            return _pricingRules.First(r => r.IsMatch(item)).CalculatePrice(item);
        }
    }
}
