using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Controllers.Transaksi
{
    public class TransaksiController : Controller
    {
        public IActionResult JadwalPertandingan()
        {
            ViewBag.Title = "Jadwal Pertandingan";
            return View();
        }

        public IActionResult HasilPertandingan()
        {
            ViewBag.Title = "Hasil Pertandingan";
            return View();
        }
    }
}
