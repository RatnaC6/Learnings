using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sess2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sess2.Controllers
{
    public class OfficeController : Controller
    {
        OfficeRepository repo = new OfficeRepository();

        // GET: OfficeController
        public ActionResult Index()
        {
            return View(this.repo.GetAllOffices());
        }

        //[HttpPost]
        //[Route("Office/Find")]
        public ActionResult Find([FromQuery] string city)
        {            
           return View("Index",this.repo.GetOfficeByCity(city));              
        }

    }
}
