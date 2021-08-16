using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Contract.Master;
using WebTest.Data.Table.Master;

namespace WebTest.Data.Repository.Delete
{
    public class PosisiRepo : IPosisi
    {
        private readonly MasterDbContext context = new MasterDbContext();

        public async Task<List<Posisi>> GetAll()
        {
            using (var context = new MasterDbContext())
            {
                var model = await context.Posisis.Where(x => x.flag).ToListAsync();
                return model;
            }
        }

        public async Task<bool> Hapus(Posisi model)
        {
            using (var context = new MasterDbContext())
            {
                var check = await context.Posisis.FirstOrDefaultAsync(x => x.id_posisi == model.id_posisi);
                if (check != null)
                {
                    check.flag = false;
                    context.Posisis.Update(check);
                    await context.SaveChangesAsync();
                }
            }
            return true;
        }

        public async Task<bool> Simpan(Posisi model)
        {
            using (var context = new MasterDbContext())
            {
                if (model.id_posisi != 0 && model.id_posisi != null)
                {
                    var check = await context.Posisis.FirstOrDefaultAsync(x => x.id_posisi == model.id_posisi);
                    if (check != null)
                    {
                        check.id_posisi = model.id_posisi;
                        context.Posisis.Update(check);
                        await context.SaveChangesAsync();
                    }
                }
                else
                {
                    context.Posisis.Add(model);
                    await context.SaveChangesAsync();
                }
            }
            return true;
        }
         
    }
}
