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
    public class JadwalPertandinganController : Controller
    {
        private readonly IJadwalPertandingan _jadwal;
        private readonly ITim _tim;

        public JadwalPertandinganController(IJadwalPertandingan jadwal, ITim tim)
        {
            _jadwal = jadwal;
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
                var model = await _jadwal.GetAll();
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public async Task<IActionResult> Simpan([FromBody] JadwalPertandingan model)
        {
            try
            {
                model.WaktuPertandingan = model.TanggalPertandingan.TimeOfDay;
                var simpan = await _jadwal.Simpan(model);
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
        public async Task<IActionResult> Hapus([FromBody] JadwalPertandingan model)
        {
            try
            {
                var simpan = await _jadwal.Hapus(model);
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
