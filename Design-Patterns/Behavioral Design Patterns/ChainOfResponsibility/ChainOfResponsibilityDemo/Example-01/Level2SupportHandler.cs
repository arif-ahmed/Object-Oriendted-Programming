using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_01
{
    public class Level2SupportHandler : SupportHandlerBase
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
