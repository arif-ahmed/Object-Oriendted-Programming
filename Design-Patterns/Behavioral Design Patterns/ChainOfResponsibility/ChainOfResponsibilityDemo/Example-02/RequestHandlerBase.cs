using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_02
{
    public abstract class RequestHandlerBase : IRequestHandler
    {
        private IRequestHandler _handler;
        public void HandleRequest(Request request)
        {
            ProcessRequest(request);

            if (_handler != null) 
            {
                _handler.HandleRequest(request);
            }
        }

        public void SetNextHandler(IRequestHandler handler)
        {
            _handler = handler;
        }

        protected abstract void ProcessRequest(Request request);
    }
}
