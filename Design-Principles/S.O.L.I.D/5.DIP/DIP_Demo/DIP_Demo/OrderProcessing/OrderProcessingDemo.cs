using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Demo.OrderProcessing
{
    public class OrderProcessingDemo
    {
        public static void Violated_Code()
        {
            Violated.Order order = new Violated.Order();
            Violated.OrderProcessor orderProcessor = new Violated.OrderProcessor();
            orderProcessor.CalculateTotal(order);
        }

        public static void Refactored_Code()
        {
            Refactored.Order order = new Refactored.Order();

            Refactored.Contracts.IDiscountCalculator discountCalculatorAdapter = new Refactored.DiscountCalculatorAdapter();
            Refactored.TaxCalculator taxCalculator = new Refactored.TaxCalculator();

            Refactored.OrderProcessor orderProcessor = new Refactored.OrderProcessor(discountCalculatorAdapter, taxCalculator);
            orderProcessor.CalculateTotal(order);
        }
    }
}
