using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern.Handlers
{
    public abstract class Handler
    {
        public Handler? nextHandler;

        public void SetNextHandler(Handler handler)
        {
            nextHandler = handler;
        }
        public abstract void HandleRequest(Request request);
    }
}
