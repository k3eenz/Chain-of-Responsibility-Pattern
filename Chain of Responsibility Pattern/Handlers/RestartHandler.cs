using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern.Handlers
{
    internal class RestartHandler : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Step == "Перезапуск")
            {
                Console.WriteLine("Перезапустите принтер.");
                request.Step = "Проверка бумаги";
            }
            if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }
}
