using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System;
using System.Net;
using System.Threading.Tasks;
using mitchelltaxgroup.Models;

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
            ViewData["Message"] = "Levy Release/Abatement.";

            return View();
        }

        public IActionResult Compromise()
        {
            ViewData["Message"] = "Offer In Compromise, (OIC).";

            return View();
        }

        public IActionResult NoneCollectible()
        {
            ViewData["Message"] = " CNC/Abatement";

            return View();
        }

        public IActionResult InjuryRelief()
        {
            ViewData["Message"] = "Innocent Spouse/Injured Spouse .";

            return View();
        }

        public IActionResult Audit()
        {
            ViewData["Message"] = "Tax Audit- Examination/Audit of Tax Return.";

            return View();
        }

        public IActionResult Lien()
        {
            ViewData["Message"] = "Lien Release.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Get to Know Our Team.";

            return View();
        }



        [HttpGet]
        public IActionResult Contact()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Contact(EmailFormModel model)
        {  
            if(ModelState.IsValid)
            {


            }

            return View();
        }


        public IActionResult Sent()
        {

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
