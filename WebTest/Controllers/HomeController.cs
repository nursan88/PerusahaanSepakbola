using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Simple Aplikasi";
            return View();
        }
        public IActionResult Privacy()
        {
            ViewBag.Title = "Privacy";
            return View();
        }
    }
}
