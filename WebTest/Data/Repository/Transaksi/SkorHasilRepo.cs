using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Contract.Transaksi;
using WebTest.Data.Table.Transaksi;

namespace WebTest.Data.Repository.Transaksi
{
    public class SkorHasilRepo : ISkorhasil
    {
        private readonly MasterDbContext context = new MasterDbContext();

        public async Task<List<SkorHasil>> GetAll(int hasilPertandinganId)
        {
            using (var context = new MasterDbContext())
            {
                var model = await context.SkorHasils.Include(x => x.Tim).Include(x => x.Pemain).Where(x => x.HasilPertandinganId == hasilPertandinganId).ToListAsync();
                return model;
            }
        }
    }
}
