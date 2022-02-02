using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Example_02.Problem
{
    public class PromoCodeStandardPriceCalculator(PromoCode promoCode) : StandardPriceCalculator
    {
        protected override decimal GetDiscount(decimal price)
        {
            var factor = promoCode switch
            {
                PromoCode.Free5 => 0.05m,
                PromoCode.Free10 => 0.10m,
                _ => throw new NotImplementedException()
            };
            return price * factor;
        }
    }
}
