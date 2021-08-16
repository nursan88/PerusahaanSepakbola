using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using WebTest.DataLog.Contract.Delete;
using WebTest.DataLog.Table.Delete;

namespace WebTest.DataLog.Repository.Delete
{
    public class DeleteHasilRepo : IDeleteHasil
    {
        private readonly LogDbContext context = new LogDbContext();

        public async Task<bool> Simpan(DeleteHasil model)
        {
            using (var context = new LogDbContext())
            {
                if (model.id_hasilpertandingan != 0 && model.id_hasilpertandingan != null)
                {
                    var check = await context.DeleteHasils.FirstOrDefaultAsync(x => x.id_hasilpertandingan == model.id_hasilpertandingan);
                    if (check != null)
                    {
                        check.id_hasilpertandingan = model.id_hasilpertandingan;
                        context.DeleteHasils.Update(check);
                        await context.SaveChangesAsync();
                    }
                }
                else
                {
                    context.DeleteHasils.Add(model);
                    await context.SaveChangesAsync();
                }
            }
            return true;
        }
         
    }
}
