using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_03
{
    public interface IOrderHandler
    {
        void SetNextHandler(IOrderHandler handler);
        void ProcessOrder(Order order);
    }
}
