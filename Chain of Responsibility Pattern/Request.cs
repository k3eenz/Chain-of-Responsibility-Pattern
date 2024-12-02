using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class Request
    {
        public string Step { get; set; }  
        public Request(string step)
        {
            Step = step;
        }
    }
}
