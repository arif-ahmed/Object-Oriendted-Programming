using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Demo.OrderProcessing.Refactored
{
    using Contracts;
    public class DiscountCalculatorAdapter : IDiscountCalculator
    {
        public decimal CalculateDiscount(Order order)
        {
            return DiscountCalculator.CalculateDiscount(order);
        }
    }
}
