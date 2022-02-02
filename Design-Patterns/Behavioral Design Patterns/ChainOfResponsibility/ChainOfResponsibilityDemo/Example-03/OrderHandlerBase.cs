using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_03
{
    public abstract class OrderHandlerBase : IOrderHandler
    {
        private IOrderHandler _nextHandler;

        public void SetNextHandler(IOrderHandler handler)
        {
            _nextHandler = handler;
        }

        public virtual void ProcessOrder(Order order)
        {
            // If this handler can process the order, do the processing
            if (CanProcessOrder(order))
            {
                Process(order);
            }
            // If there is a next handler, pass the order to it
            else if (_nextHandler != null)
            {
                _nextHandler.ProcessOrder(order);
            }
            // No handler in the chain can process the order
            else
            {
                Console.WriteLine("Order cannot be processed.");
            }
        }

        protected abstract bool CanProcessOrder(Order order);
        protected abstract void Process(Order order);
    }
}
