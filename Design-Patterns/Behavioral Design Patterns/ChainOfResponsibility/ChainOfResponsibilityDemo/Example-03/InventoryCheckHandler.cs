using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_03
{
    public class InventoryCheckHandler : OrderHandlerBase
    {
        protected override bool CanProcessOrder(Order order)
        {
            // Check inventory availability based on business rules
            return true; // Placeholder condition, actual inventory check logic would go here
        }

        protected override void Process(Order order)
        {
            Console.WriteLine("Inventory check completed for order: " + order.OrderId);
            // Perform inventory check logic
        }
    }
}
