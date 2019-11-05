using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCHello.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Greeting = DateTime.Now.Hour <= 12 ? "Good Morning!!" : "Good afternoon";
            ViewBag.GreetingScript = "<script>alert('Hello from script')</script>";
            return View();
        }

        public IActionResult About(int id)
        {
            return Content($"Hello from about {id}");
        }
    }
}