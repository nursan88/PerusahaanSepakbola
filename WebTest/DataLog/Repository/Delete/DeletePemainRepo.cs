using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.DataLog.Contract.Delete;
using WebTest.DataLog.Table.Delete;

namespace WebTest.DataLog.Repository.Delete
{
    public class DeletePemainRepo : IDeletePemain
    {
        private readonly LogDbContext context = new LogDbContext();

        public async Task<bool> Simpan(DeletePemain model)
        {
            using (var context = new LogDbContext())
            {
                if (model.Id_pemain != 0 && model.Id_pemain != null)
                {
                    var check = await context.DeletePemains.FirstOrDefaultAsync(x => x.Id_pemain == model.Id_pemain);
                    if (check != null)
                    {
                        check.Id_pemain = model.Id_pemain;
                        context.DeletePemains.Update(check);
                        await context.SaveChangesAsync();
                    }
                }
                else
                {
                    context.DeletePemains.Add(model);
                    await context.SaveChangesAsync();
                }
            }
            return true;
        }
    }
}
