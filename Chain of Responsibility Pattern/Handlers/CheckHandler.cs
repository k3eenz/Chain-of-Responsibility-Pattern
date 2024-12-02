using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern.Handlers
{
    internal class CheckHandler : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Step == "Проверка бумаги")
            {
                Console.WriteLine("Нет ли застрявшей бумаги?");
                request.Step = "Обновление драйверов"; 
            }
            if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }
}
