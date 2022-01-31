using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Demo.OrderProcessing.Violated
{
    public class DiscountCalculator
    {
        public static decimal CalculateDiscount(Order order)
        {
            return 1.0m;
        }
    }
}
