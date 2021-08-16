using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Contract.Master;
using WebTest.Data.Table.Master;

namespace WebTest.Data.Repository.Master
{
    public class TimPemainRepo : ITimPemain
    {
        private readonly MasterDbContext context = new MasterDbContext();
        public async Task<List<TimPemain>> GetAll()
        {
            var model = await context.TimPemains.ToListAsync();
            return model;
        }

        public async Task<TimPemain> Simpan(TimPemain model)
        {
            var check = await context.TimPemains.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (check != null)
            {
                check.PemainId = model.PemainId;
                check.NamaTimId = model.NamaTimId;
                context.TimPemains.Update(check);
                await context.SaveChangesAsync();
                return check;
            }
            else
            {
                await context.TimPemains.AddAsync(model);
                await context.SaveChangesAsync();
                return model;
            }
        }
    }
}
