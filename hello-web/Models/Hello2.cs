using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hello_web.Models
{
    public class Hello2 : IHello
    {
        public string sayHelloTo(string to)
        {
            return "HeLlO, " + to.ToUpper() + "!";
        }
    }
}