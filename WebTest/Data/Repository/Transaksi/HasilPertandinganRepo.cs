using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Contract.Transaksi;
using WebTest.Data.Table.Transaksi;

namespace WebTest.Data.Repository.Delete
{
    public class HasilPertandinganRepo : IHasilPertandingan
    {
        private readonly MasterDbContext context = new MasterDbContext();

        public async Task<List<HasilPertandingan>> GetAll()
        {
            using (var context = new MasterDbContext())
            {
                var model = await context.HasilPertandingans.Where(x => x.flag).ToListAsync();
                return model;
            }
        }

        public async Task<bool> Hapus(HasilPertandingan model)
        {
            using (var context = new MasterDbContext())
            {
                var check = await context.HasilPertandingans.FirstOrDefaultAsync(x => x.Id == model.Id);
                if (check != null)
                {
                    check.flag = false;
                    context.HasilPertandingans.Update(check);
                    await context.SaveChangesAsync();
                }
            }
            return true;
        }

        public async Task<HasilPertandingan> Simpan(HasilPertandingan model)
        {
            using (var context = new MasterDbContext())
            {
                if (model.Id != 0 && model.Id != null)
                {
                    var check = await context.HasilPertandingans.FirstOrDefaultAsync(x => x.Id == model.Id);
                    if (check != null)
                    {
                        check.Id = model.Id;
                        check.JadwalPertandingan = model.JadwalPertandingan;
                        check.JadwalPertandinganid_jadwal = model.JadwalPertandinganid_jadwal;
                        check.HasilSkor = model.HasilSkor;
                        check.SkorPertandingan = model.SkorPertandingan;
                        check.SkorTimTamu = model.SkorTimTamu;
                        check.SkorTimTuanRumah = model.SkorTimTuanRumah;
                        check.flag = model.flag;
                        context.HasilPertandingans.Update(check);
                        await context.SaveChangesAsync();
                        return check;
                    }
                }
                else
                {
                    model.flag = true;
                    context.HasilPertandingans.Add(model);
                    await context.SaveChangesAsync();
                    return model;
                }
            }
            return model;
        }

    }
}
