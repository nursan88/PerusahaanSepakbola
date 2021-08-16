using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Contract.Transaksi;
using WebTest.Data.Table.Transaksi;

namespace WebTest.Data.Repository.Transaksi
{
    public class JadwalPertandinganRepo : IJadwalPertandingan
    {
        private readonly MasterDbContext context = new MasterDbContext();

        public async Task<List<JadwalPertandingan>> GetAll()
        {
            using (var context = new MasterDbContext())
            {
                var model = await context.JadwalPertandingans.Include(x => x.TimTamu).Include(x => x.TimTuanRumah).Where(x => x.flag).ToListAsync();
                return model;
            }
        }

        public async Task<bool> Hapus(JadwalPertandingan model)
        {
            using (var context = new MasterDbContext())
            {
                var check = await context.JadwalPertandingans.FirstOrDefaultAsync(x => x.id_jadwal == model.id_jadwal);
                if (check != null)
                {
                    check.flag = false;
                    context.JadwalPertandingans.Update(check);
                    await context.SaveChangesAsync();
                }
            }
            return true;
        }

        public async Task<bool> Simpan(JadwalPertandingan model)
        {
            using (var context = new MasterDbContext())
            {
                if (model.id_jadwal != 0 && model.id_jadwal != null)
                {
                    var check = await context.JadwalPertandingans.FirstOrDefaultAsync(x => x.id_jadwal == model.id_jadwal);
                    if (check != null)
                    {
                        check.id_jadwal = model.id_jadwal;
                        check.TanggalPertandingan = model.TanggalPertandingan;
                        check.WaktuPertandingan = model.WaktuPertandingan;
                        check.TimTamu = model.TimTamu;
                        check.TimTamuId_tim = model.TimTamuId_tim;
                        check.TimTuanRumah = model.TimTuanRumah;
                        check.TimTuanRumahId_tim = model.TimTuanRumahId_tim;
                        check.flag = model.flag;
                        context.JadwalPertandingans.Update(check);
                        await context.SaveChangesAsync();
                    }
                }
                else
                {
                    model.flag = true;
                    context.JadwalPertandingans.Add(model);
                    await context.SaveChangesAsync();
                }
            }
            return true;
        }

    }
}
