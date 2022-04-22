using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sess2.Controllers
{
    public class MembersController : Controller
    {
        [Authorize] //Will be processed before request
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 300,Location = ResponseCacheLocation.Any)] //a.k.a Output Caching
        //Will be processed after request
        public IEnumerable<string> MemberList()
        {
            string[] members = { "abc", "pqr", "xyz", "jkl" };
            return members;
        }

        [AllowAnonymous] //Login optional for this Action
        public IActionResult NonSecure()
        {
            return View();
        }
    }
}
