using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_02
{
    public interface IRequestHandler
    {
        void SetNextHandler(IRequestHandler handler);
        void HandleRequest(Request request);
    }
}
