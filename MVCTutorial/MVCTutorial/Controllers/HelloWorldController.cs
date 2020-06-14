using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        // GET /HelloWorld/
        /* public string Index() {
            return "This is my default action...";
        }
        // GET /HelloWorld/Welcome
        public string Welcome()
        {
            return "This is the welcome action method";
        } */
    }
}
