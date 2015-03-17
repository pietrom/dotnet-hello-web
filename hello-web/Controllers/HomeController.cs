using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hello_web.Models;

namespace hello_web.Controllers
{
    public class HomeController : Controller
    {
        private IHello hello;

        public HomeController(IHello helloParam)
        {
            this.hello = helloParam;
        }

        public HomeController() : this(new DefaultHello())
        {}

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hello()
        { 
            ViewBag.HelloMessage = hello.sayHelloTo("World");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}