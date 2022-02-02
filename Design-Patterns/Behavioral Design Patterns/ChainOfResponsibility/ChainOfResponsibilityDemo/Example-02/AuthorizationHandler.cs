using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_02
{
    public class AuthorizationHandler : RequestHandlerBase
    {
        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine("Authorization handler processing request");
            // Perform authorization logic
        }
    }
}
