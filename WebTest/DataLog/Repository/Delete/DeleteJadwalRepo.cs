using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.DataLog;
using WebTest.DataLog.Contract.Delete;
using WebTest.DataLog.Table.Delete;

namespace WebTest.DataLog.Repository.Delete
{
    public class DeleteJadwalRepo : IDeleteJadwal
    {
        private readonly LogDbContext context = new LogDbContext();

        public async Task<bool> Simpan(DeleteJadwal model)
        {
            using (var context = new LogDbContext())
            {
                if (model.id_jadwal != 0 && model.id_jadwal != null)
                {
                    var check = await context.DeleteJadwals.FirstOrDefaultAsync(x => x.id_jadwal == model.id_jadwal);
                    if (check != null)
                    {
                        check.id_jadwal = model.id_jadwal;
                        context.DeleteJadwals.Update(check);
                        await context.SaveChangesAsync();
                    }
                }
                else
                {
                    context.DeleteJadwals.Add(model);
                    await context.SaveChangesAsync();
                }
            }
            return true;
        }
         
    }
}
