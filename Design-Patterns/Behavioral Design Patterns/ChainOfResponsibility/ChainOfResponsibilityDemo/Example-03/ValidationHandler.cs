using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_03
{
    public class ValidationHandler : OrderHandlerBase
    {
        protected override bool CanProcessOrder(Order order)
        {
            // Perform validation checks based on business rules
            return true; // Placeholder condition, actual validation logic would go here
        }

        protected override void Process(Order order)
        {
            Console.WriteLine("Validation completed for order: " + order.OrderId);
            // Perform order validation logic
        }
    }
}
