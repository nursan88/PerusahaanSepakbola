using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Table.Transaksi;

namespace WebTest.Data.Contract.Transaksi
{
    public interface ISkorhasil
    {
        Task<List<SkorHasil>> GetAll();
    }
}
