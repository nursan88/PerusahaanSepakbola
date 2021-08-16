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
    public class TimController : Controller
    {

        private readonly ITim _tim;
        //private readonly IPosisiPemain _iPosisiPemain;
        public TimController(ITim tim)
        {
            _tim = tim;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var model = await _tim.GetAll();
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public async Task<IActionResult> Simpan([FromBody] Tim model)
        {
            try
            { 
                var simpan = await _tim.Simpan(model);
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
        public async Task<IActionResult> Hapus([FromBody] Tim model)
        {
            try
            {
                var simpan = await _tim.Hapus(model);
                if (simpan)
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
