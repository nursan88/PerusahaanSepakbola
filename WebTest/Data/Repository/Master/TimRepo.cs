using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Contract.Master;
using WebTest.Data.Table.Master;

namespace WebTest.Data.Repository.Delete
{
    public class TimRepo : ITim
    {
        private readonly MasterDbContext context = new MasterDbContext();

        public async Task<List<Tim>> GetAll()
        {
            using (var context = new MasterDbContext())
            {
                var model = await context.Tims.Where(x => x.flag).ToListAsync();
                return model;
            }
        }

        public async Task<bool> Hapus(Tim model)
        {
            using (var context = new MasterDbContext())
            {
                var check = await context.Tims.FirstOrDefaultAsync(x => x.Id_tim == model.Id_tim);
                if (check != null)
                {
                    check.flag = false;
                    context.Tims.Update(check);
                    await context.SaveChangesAsync();
                }
            }
            return true;
        }

        public async Task<bool> Simpan(Tim model)
        {
            using (var context = new MasterDbContext())
            {
                if (model.Id_tim != 0 && model.Id_tim != null)
                {
                    var check = await context.Tims.FirstOrDefaultAsync(x => x.Id_tim == model.Id_tim);
                    if (check != null)
                    {
                        check.Id_tim = model.Id_tim;
                        check.flag = model.flag;
                        check.NamaTim = model.NamaTim;
                        check.TahunBerdiri = model.TahunBerdiri;
                        check.AlamatTim = model.AlamatTim;
                        check.KotaTim = model.KotaTim;
                        check.LogoTim = model.LogoTim;

                        context.Tims.Update(check);
                        await context.SaveChangesAsync();
                    }
                }
                else
                {
                    model.flag = true;
                    context.Tims.Add(model);
                    await context.SaveChangesAsync();
                }
            }
            return true;
        }
         
    }
}
