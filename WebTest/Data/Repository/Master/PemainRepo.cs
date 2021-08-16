using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Contract.Master;
using WebTest.Data.Table.Master;

namespace WebTest.Data.Repository.Delete
{
    public class PemainRepo : IPemain
    {
        private readonly MasterDbContext context = new MasterDbContext();

        public async Task<bool> CheckNo(int no, int timId)
        {
            var model = await context.Pemains.FirstOrDefaultAsync(x => x.NoPunggung == no && x.TimPemainId_tim == timId);
            if (model == null)
                return true;
            else
                return false;
        }

        public async Task<List<Pemain>> GetAll()
        {
            using (var context = new MasterDbContext())
            {
                var model = await context.Pemains.Include(x => x.PosisiPemain).Include(x => x.TimPemain).Where(x => x.flag).ToListAsync();
                return model;
            }
        }

        public async Task<List<Pemain>> GetPemainByTimId(int timId)
        {
            using (var context = new MasterDbContext())
            {
                var model = await context.Pemains.Include(x => x.PosisiPemain).Include(x => x.TimPemain).Where(x => x.flag && x.TimPemainId_tim == timId).ToListAsync();
                return model;
            }
        }

        public async Task<Pemain> Hapus(Pemain model)
        {
            using (var context = new MasterDbContext())
            {
                if (model.Id_pemain != 0 && model.Id_pemain != null)
                {
                    var check = await context.Pemains.FirstOrDefaultAsync(x => x.Id_pemain == model.Id_pemain);
                    if (check != null)
                    {
                        check.Id_pemain = model.Id_pemain;
                        check.TimPemainId_tim = model.TimPemainId_tim;
                        check.flag = false;
                        context.Pemains.Update(check);
                        await context.SaveChangesAsync();
                        return check;
                    }
                }
                else
                {
                    context.Pemains.Add(model);
                    await context.SaveChangesAsync();
                    return model;
                }
            }
            return model;
        }

        public async Task<Pemain> Simpan(Pemain model)
        {
            using (var context = new MasterDbContext())
            {
                if (model.Id_pemain != 0 && model.Id_pemain != null)
                {
                    var check = await context.Pemains.FirstOrDefaultAsync(x => x.Id_pemain == model.Id_pemain);
                    if (check != null)
                    {
                        check.Id_pemain = model.Id_pemain;
                        check.TimPemainId_tim = model.TimPemainId_tim;
                        check.NamaPemain = model.NamaPemain;
                        check.NoPunggung = model.NoPunggung;
                        check.PosisiPemain = model.PosisiPemain;
                        check.PosisiPemainId = model.PosisiPemainId;
                        check.TimPemain = model.TimPemain;
                        check.TinggiBadan = model.TinggiBadan;
                        check.BeratBadan = model.BeratBadan;
                        check.flag = model.flag;
                        context.Pemains.Update(check);
                        await context.SaveChangesAsync();
                        return check;
                    }
                }
                else
                {
                    model.flag = true;
                    context.Pemains.Add(model);
                    await context.SaveChangesAsync();
                    return model;
                }
            }
            return model;
        }

    }
}
