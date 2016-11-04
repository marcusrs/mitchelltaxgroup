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

        public IActionResult Installments()
        {
            ViewData["Message"] = "Installment Agreement.";

            return View();
        }

        public IActionResult IRSlevy()
        {
            ViewData["Message"] = " CNC/Levy Release/Abatement.";

            return View();
        }

        public IActionResult Compromise()
        {
            ViewData["Message"] = "What to Bring With You.";

            return View();
        }

        public IActionResult NoneCollectible()
        {
            ViewData["Message"] = "What to Bring With You.";

            return View();
        }

        public IActionResult InjuryRelief()
        {
            ViewData["Message"] = "What to Bring With You.";

            return View();
        }

        public IActionResult Audit()
        {
            ViewData["Message"] = "What to Bring With You.";

            return View();
        }

        public IActionResult Lien()
        {
            ViewData["Message"] = "What to Bring With You.";

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
