using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.DataLog.Contract.Delete;
using WebTest.DataLog.Table.Delete;

namespace WebTest.DataLog.Repository.Delete
{
    public class DeletePosisiRepo : IDeletePosisi
    {
        private readonly LogDbContext context = new LogDbContext();

        public async Task<bool> Simpan(DeletePosisi model)
        {
            using (var context = new LogDbContext())
            {
                if (model.id_posisi != 0 && model.id_posisi != null)
                {
                    var check = await context.DeletePosisis.FirstOrDefaultAsync(x => x.id_posisi == model.id_posisi);
                    if (check != null)
                    {
                        check.id_posisi = model.id_posisi;
                        context.DeletePosisis.Update(check);
                        await context.SaveChangesAsync();
                    }
                }
                else
                {
                    context.DeletePosisis.Add(model);
                    await context.SaveChangesAsync();
                }
            }
            return true;
        }
    }
}
