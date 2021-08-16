using Microsoft.AspNetCore.Mvc;
using WebTest.Data.Contract.Master;
using WebTest.Data.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Table.Master;

namespace WebTest.Controllers.Master
{
    public class PemainController : Controller
    {

        private readonly IPemain _pemain;
        private readonly IPosisiPemain _iPosisiPemain;
        private readonly ITim _itim;
        public PemainController(IPemain pemain, IPosisiPemain iPosisiPemain, ITim itim)
        {
            _pemain = pemain;
            _iPosisiPemain = iPosisiPemain;
            _itim = itim;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> CheckNo(int no, int timId)
        {
            var model = await _pemain.CheckNo(no, timId);
            return Ok(model);
        }
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var model = await _pemain.GetAll();
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public async Task<IActionResult> GetPemainByTimId(int timId)
        {
            try
            {
                var model = await _pemain.GetPemainByTimId(timId);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public async Task<IActionResult> Simpan([FromBody] Pemain model)
        {
            try
            {
                var simpan = await _pemain.Simpan(model);
                if (simpan != null)
                {
                    return Ok("Simpan Data Berhasil");
                }
                else
                    return BadRequest("Simpan Data Gagal");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
        public async Task<IActionResult> Hapus([FromBody] Pemain model)
        {
            try
            {
                var simpan = await _pemain.Hapus(model);
                if (simpan != null)
                    return Ok("Hapus Data Berhasil");
                else
                    return BadRequest("Hapus Data Gagal");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
    }
}
