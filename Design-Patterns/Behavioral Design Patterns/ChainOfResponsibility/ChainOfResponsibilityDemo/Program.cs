using ChainOfResponsibilityDemo.Example_01;

namespace ChainOfResponsibilityDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example_01_Demo();
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
    }
}
