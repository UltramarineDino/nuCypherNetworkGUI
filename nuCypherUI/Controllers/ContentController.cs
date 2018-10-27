using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronNET.API;
using Microsoft.AspNetCore.Mvc;

namespace nuCypherUI.Controllers
{
    public class ContentController : CustomController
    {
        [HttpGet]
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Bids()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Settings()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DashboardData()
        {
            return Json(ApiDataAdapter.GetDashboardData());
        }

        [HttpGet]
        public IActionResult BalanceData()
        {
            return Json(ApiDataAdapter.GetBalanceData());
        }
    }
}