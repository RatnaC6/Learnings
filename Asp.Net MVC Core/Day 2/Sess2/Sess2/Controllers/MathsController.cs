using Microsoft.AspNetCore.Mvc;
using Sess2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sess2.Controllers
{
    public class MathsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
       
        [Route("Maths/Index")] //Attribute based Routing
        public IActionResult Index(Inputs inputs)
        {                      
            ViewData["Result"] = inputs.X + inputs.Y; 
            return View();
        }
    }
}
