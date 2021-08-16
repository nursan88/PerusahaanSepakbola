using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Contract.Master;
using WebTest.Data.Contract.Transaksi;
using WebTest.Data.Table.Transaksi;

namespace WebTest.Controllers.Transaksi
{
    public class SkorHasilController : Controller
    {
        private readonly ISkorhasil _detail;

        public SkorHasilController(ISkorhasil detail)
        {
            _detail = detail;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetAll(int hasilPertandinganId)
        {
            try
            {
                var model = await _detail.GetAll(hasilPertandinganId);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
