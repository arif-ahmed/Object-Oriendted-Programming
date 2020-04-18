using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Demo.OrderProcessing.Refactored.Contracts
{
    public interface ITaxStrategy
    {
        string Identifier { get; }
        decimal FindTaxAmount();
    }
}
