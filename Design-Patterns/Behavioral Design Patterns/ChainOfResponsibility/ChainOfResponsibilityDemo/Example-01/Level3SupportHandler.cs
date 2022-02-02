namespace ChainOfResponsibilityDemo.Example_01
{
    public class Level3SupportHandler : SupportHandlerBase
    {
        protected override bool CanHandleTicket(Ticket ticket)
        {
            return ticket.Severity == Severity.High;
        }

        protected override void Handle(Ticket ticket)
        {
            Console.WriteLine("Level 3 Support handles the ticket.");
            // Handle the ticket at Level 3 Support
        }
    }
}
