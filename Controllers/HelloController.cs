using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCHello.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {
            return "Hello from index in HelloController";
        }

        public string About(int id)
        {
            return $"Hello from About with id {id}";
        }
    }
}