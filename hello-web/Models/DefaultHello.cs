using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hello_web.Models
{
    public class DefaultHello : IHello
    {
        public string sayHelloTo(string to)
        {
            return "Hello, World! (fixed)";
        }
    }
}