using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_02
{
    public class ValidationHandler : RequestHandlerBase
    {
        protected override void ProcessRequest(Request request)
        {
            Console.WriteLine("Validation handler processing request");
            // Perform validation logic
        }
    }
}
