using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mitchelltaxgroup.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "We Provide Tax Solutions for You."; 
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Get to Know Our Team.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Us";

            return View();
        }

        public IActionResult whatTobring()
        {
            ViewData["Message"] = "What to Bring With You.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
