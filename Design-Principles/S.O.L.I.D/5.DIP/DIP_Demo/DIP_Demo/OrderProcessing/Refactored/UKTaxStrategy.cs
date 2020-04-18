using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Demo.OrderProcessing.Refactored
{
    using Contracts;
    public class UKTaxStrategy : ITaxStrategy
    {
        public string Identifier { get; } = "UK";
        public decimal FindTaxAmount()
        {
            return 10.0m;
        }
    }
}
