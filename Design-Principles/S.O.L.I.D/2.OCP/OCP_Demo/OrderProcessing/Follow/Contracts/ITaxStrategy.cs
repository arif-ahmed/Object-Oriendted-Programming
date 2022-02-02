using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Follow.Contracts
{
    public interface ITaxStrategy
    {
        decimal FindTaxAmount(Order order);
    }
}
