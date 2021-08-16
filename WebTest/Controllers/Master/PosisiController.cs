using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Contract.Master;
using WebTest.Data.Table.Master;

namespace WebTest.Controllers.Master
{
    public class PosisiController : Controller
    {
        private readonly IPosisi _iPosisi;
        public PosisiController(IPosisi iPosisi)
        {
            _iPosisi = iPosisi;
        }
        public async Task<IActionResult> GetAll()
        {
            var model = await _iPosisi.GetAll();
            return Ok(model);
        }
        public async Task<IActionResult> Simpan([FromBody] Posisi model)
        {
            if (ModelState.IsValid)
            {
                var simpan = await _iPosisi.Simpan(model);
                return Ok(simpan);
            }
            return BadRequest("Terjadi kesalahan");
        }
    }
}
