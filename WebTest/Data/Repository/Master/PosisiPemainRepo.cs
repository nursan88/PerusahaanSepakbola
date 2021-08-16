using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Contract.Master;
using WebTest.Data.Table.Master;

namespace WebTest.Data.Repository.Master
{
    public class PosisiPemainRepo : IPosisiPemain
    {
        private readonly MasterDbContext context = new MasterDbContext();
        public async Task<List<PosisiPemain>> GetAll()
        {
            var model = await context.PosisiPemains.ToListAsync();
            return model;
        }

        public async Task<PosisiPemain> Simpan(PosisiPemain model)
        {
            var check = await context.PosisiPemains.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (check != null)
            {
                check.PemainId = model.PemainId;
                check.PosisiId = model.PosisiId;
                context.PosisiPemains.Update(check);
                await context.SaveChangesAsync();
                return check;
            }
            else
            {
                await context.PosisiPemains.AddAsync(model);
                await context.SaveChangesAsync();
                return model;
            }
        }
    }
}
