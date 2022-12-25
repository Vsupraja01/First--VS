using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int a = 10;
            int b = 20;
            if (a > b)
            {
                Console.WriteLine("False");
            }
            return View();
        }
    }
}
