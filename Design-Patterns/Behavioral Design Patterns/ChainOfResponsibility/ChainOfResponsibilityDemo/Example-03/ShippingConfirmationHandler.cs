using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_03
{
    public class ShippingConfirmationHandler : OrderHandlerBase
    {
        protected override bool CanProcessOrder(Order order)
        {
            // Confirm shipping details based on business rules
            return true; // Placeholder condition, actual shipping confirmation logic would go here
        }

        protected override void Process(Order order)
        {
            Console.WriteLine("Shipping confirmation completed for order: " + order.OrderId);
            // Perform shipping confirmation logic
        }
    }
}
