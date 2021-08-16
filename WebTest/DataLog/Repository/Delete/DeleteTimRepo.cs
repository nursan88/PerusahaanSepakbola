using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.DataLog.Contract.Delete;
using WebTest.DataLog.Table.Delete;

namespace WebTest.DataLog.Repository.Delete
{
    public class DeleteTimRepo : IDeleteTim
    {
        private readonly LogDbContext context = new LogDbContext();

        public async Task<bool> Simpan(DeleteTim model)
        {
            using (var context = new LogDbContext())
            {
                if (model.Id_tim != 0 && model.Id_tim != null)
                {
                    var check = await context.DeleteTims.FirstOrDefaultAsync(x => x.Id_tim == model.Id_tim);
                    if (check != null)
                    {
                        check.Id_tim = model.Id_tim;
                        context.DeleteTims.Update(check);
                        await context.SaveChangesAsync();
                    }
                }
                else
                {
                    context.DeleteTims.Add(model);
                    await context.SaveChangesAsync();
                }
            }
            return true;
        }

    }
}
