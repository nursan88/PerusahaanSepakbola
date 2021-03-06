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
    public class HasilPertandinganController : Controller
    {
        private readonly IHasilPertandingan _hasil;
        private readonly ITim _tim;
        private readonly IPemain _pemain;

        public HasilPertandinganController(IHasilPertandingan hasil, ITim tim, IPemain pemain)
        {
            _hasil = hasil;
            _tim = tim;
            _pemain = pemain;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var model = await _hasil.GetAll();
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public async Task<IActionResult> Simpan([FromBody] HasilPertandingan model)
        {
            try
            { 
                var simpan = await _hasil.Simpan(model);    
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
        public async Task<IActionResult> Hapus([FromBody] HasilPertandingan model)
        {
            try
            {
                var simpan = await _hasil.Hapus(model);
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
