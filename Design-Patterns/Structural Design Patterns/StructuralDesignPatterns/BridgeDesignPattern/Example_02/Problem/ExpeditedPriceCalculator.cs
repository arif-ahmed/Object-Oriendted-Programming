using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Example_02.Problem
{
    public class ExpeditedPriceCalculator : PriceCalculator
    {
        protected override decimal GetDeliveryFee() => 5m;
        protected override decimal GetDiscount(decimal price) => 0;
    }
}
