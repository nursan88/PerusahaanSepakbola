using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Controllers.Master
{
    public class MasterController : Controller
    {
        public IActionResult MasterPemain()
        {
            ViewBag.Title = "Daftar Pemain";
            return View();
        }

        public IActionResult MasterTim()
        {
            ViewBag.Title = "Daftar TIM";
            return View();
        }

    }
}
