using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Demo.OrderProcessing.Refactored
{
    using Contracts;
    public class OrderProcessor
    {
        private readonly IDiscountCalculator _discountCalculatorAdapter;
        private readonly TaxCalculator _taxCalculator;

        public OrderProcessor(IDiscountCalculator discountCalculatorAdapter, TaxCalculator taxCalculator)
        {
            _discountCalculatorAdapter = discountCalculatorAdapter;
            _taxCalculator = taxCalculator;
        }
        public decimal CalculateTotal(Order order)
        {
            decimal itemTotal = order.GetItemTotal();
            decimal discountAmount = _discountCalculatorAdapter.CalculateDiscount(order);
            decimal taxAmount = _taxCalculator.CalculateTax(order);
            
            decimal total = itemTotal - discountAmount + taxAmount;
            return total;
        }
    }
}
