using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurCoreMvcApp.Areas.Users.Controllers
{
    public class HomeController : Controller
    {
        [Area("Users")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
