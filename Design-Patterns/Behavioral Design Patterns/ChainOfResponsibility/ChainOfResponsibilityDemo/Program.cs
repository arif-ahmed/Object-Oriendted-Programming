using ChainOfResponsibilityDemo.Example_01;
using ChainOfResponsibilityDemo.Example_02;
using ChainOfResponsibilityDemo.Example_03;
using ChainOfResponsibilityDemo.Example_04;

namespace ChainOfResponsibilityDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example_01_Demo();
            // Example_02_Demo();
            // Example_03_Demo();
            Example_04_Demo();
            Console.ReadKey();
        }

        static void Example_01_Demo() 
        {
            // Create the support handlers
            var level3SupportHandler = new Level3SupportHandler();
            var level2SupportHandler = new Level2SupportHandler();
            var level1SupportHandler = new Level1SupportHandler();

            // Set the chain of responsibility
            level1SupportHandler.SetNextHandler(level2SupportHandler);
            level2SupportHandler.SetNextHandler(level3SupportHandler);

            // Create tickets
            var ticket1 = new Ticket { Severity = Severity.Low };
            var ticket2 = new Ticket { Severity = Severity.Medium };
            var ticket3 = new Ticket { Severity = Severity.High };

            // Process the tickets
            level1SupportHandler.HandleTicket(ticket1);
            level1SupportHandler.HandleTicket(ticket2);
            level1SupportHandler.HandleTicket(ticket3);
        }

        static void Example_02_Demo()
        {
            // Create the request handlers
            var authenticationHandler = new AuthenticationHandler();
            var authorizationHandler = new AuthorizationHandler();
            var validationHandler = new Example_02.ValidationHandler();

            // Set the chain of responsibility
            authenticationHandler.SetNextHandler(authorizationHandler);
            authorizationHandler.SetNextHandler(validationHandler);

            // Create a request
            var request = new Request { Content = "Sample request" };

            // Process the request
            authenticationHandler.HandleRequest(request);
        }

        static void Example_03_Demo() 
        {
            // Create the order handlers
            var validationHandler = new Example_03.ValidationHandler();
            var inventoryCheckHandler = new InventoryCheckHandler();
            var paymentVerificationHandler = new PaymentVerificationHandler();
            var shippingConfirmationHandler = new ShippingConfirmationHandler();

            // Set the chain of responsibility
            validationHandler.SetNextHandler(inventoryCheckHandler);
            inventoryCheckHandler.SetNextHandler(paymentVerificationHandler);
            paymentVerificationHandler.SetNextHandler(shippingConfirmationHandler);

            // Create an order
            var order = new Order { OrderId = "12345", TotalAmount = 100.0M };

            // Process the order
            validationHandler.ProcessOrder(order);
        }

        static void Example_04_Demo()
        {
            // Setup Chain of Responsibility
            var larry = new Director();
            var sam = new VicePresident();
            var tammy = new President();
            larry.Successor = sam;
            sam.Successor = tammy;
            // Generate and process purchase requests
            var purchase = new Purchase { Number = 2034, Amount = 350.00, Purpose = "Supplies" };
            larry.ProcessRequest(purchase);
            purchase = new Purchase { Number = 2035, Amount = 32590.10, Purpose = "Project X" };
            larry.ProcessRequest(purchase);
            purchase = new Purchase { Number = 2036, Amount = 122100.00, Purpose = "Project Y" };
            larry.ProcessRequest(purchase);
            // Wait for user
            Console.ReadKey();
        }
    }
}
