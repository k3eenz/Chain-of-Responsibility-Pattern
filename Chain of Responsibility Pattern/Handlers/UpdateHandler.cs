using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern.Handlers
{
    public class UpdateHandler : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Step == "Обновление драйверов")
            {
                Console.WriteLine("Обновите драйвера");
                request.Step = "Решение проблемы";  
            }
            if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }
}
