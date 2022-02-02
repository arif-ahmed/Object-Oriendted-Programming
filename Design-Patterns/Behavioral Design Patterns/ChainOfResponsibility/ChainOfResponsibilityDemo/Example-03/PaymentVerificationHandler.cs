using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_03
{
    public class PaymentVerificationHandler : OrderHandlerBase
    {
        protected override bool CanProcessOrder(Order order)
        {
            // Verify payment details based on business rules
            return true; // Placeholder condition, actual payment verification logic would go here
        }

        protected override void Process(Order order)
        {
            Console.WriteLine("Payment verification completed for order: " + order.OrderId);
            // Perform payment verification logic
        }
    }
}
