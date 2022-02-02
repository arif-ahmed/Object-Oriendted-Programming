
namespace ChainOfResponsibilityDemo.Example_01
{
    public class Level1SupportHandler : SupportHandlerBase
    {
        protected override bool CanHandleTicket(Ticket ticket)
        {
            return ticket.Severity == Severity.Low;
        }

        protected override void Handle(Ticket ticket)
        {
            Console.WriteLine("Level 1 Support handles the ticket.");
            // Handle the ticket at Level 1 Support
        }
    }
}
