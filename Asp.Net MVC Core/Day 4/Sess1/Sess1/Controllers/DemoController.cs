using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sess1.Controllers
{
    public class DemoController : Controller
    {
        string []locations = { "Mumbai", "Bangalore", "Pune", "London", "Toronto", "Delhi" };
        public IActionResult Index()
        {
            //return RedirectToAction("Timing");
            ViewData["locations"] = locations;
            return View();
        }

        public IActionResult Locations()
        {
            ViewData["locations"] = locations;
            return PartialView("_Locations");
        }

        public IActionResult Timing()
        {
            return Content(DateTime.Now.ToShortTimeString());
        }

        public IActionResult Greeting()
        {
            return Content("Hi from Viren");
        }
    }
}
