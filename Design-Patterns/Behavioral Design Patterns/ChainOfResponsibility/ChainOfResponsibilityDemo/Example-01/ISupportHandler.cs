using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_01
{
    public interface ISupportHandler
    {
        void SetNextHandler(ISupportHandler handler);
        void HandleTicket(Ticket ticket);
    }
}
