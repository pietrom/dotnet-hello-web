using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hello_web.Models
{
    public class Hello : IHello
    {
        public string sayHelloTo(string target)
        {
            return string.Format("Hello (from Hello class), {0}!", target);
        }
    }
}