using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OurCoreMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurCoreMvcApp.Controllers
{
    public class AuthController : Controller
    {
        const string SessionVal = "_val";
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string userName, string pass)
        {
            var result = (from c in GetUsers()
                          where c.UserName == userName && c.Password == pass
                          select c).ToList();

            string strUser = "";
            foreach(var item in result)
            {
                strUser = item.UserName;
            }

            if (result.Count > 0)
            {
                HttpContext.Session.SetString(SessionVal, strUser);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Username or Password invalid!";
            }

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SessionVal);

            return RedirectToAction("Login", "Auth");
        }

        [HttpPost]
        public IActionResult Logout(string logOut)
        {
            HttpContext.Session.Remove(SessionVal);

            return RedirectToAction("Login", "Auth");
        }

        public List<Users> GetUsers()
        {
            List<Users> aLst = new List<Users>()
            {
                new Users() { UserName = "Aziz", Password = "1234" },
                new Users() { UserName = "Amit", Password = "1234" },
            };

            return aLst;
        }
    }
}
