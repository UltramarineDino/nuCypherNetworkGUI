using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ElectronNET.API;
using Microsoft.AspNetCore.Mvc;
using nuCypherUI.Models;
using nuCypherUI.Utils;

namespace nuCypherUI.Controllers
{
    public class MainController : CustomController
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            string authData = $"Login: {login} Password: {password}";

            if (Cerberus.CanPass(login, password))
            {
                return RedirectToAction("Dashboard", "Content");
            }

            return View();
        }

        public IActionResult Logout()
        {
            // ToDo: clear params, etc.

            return View("Login");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
