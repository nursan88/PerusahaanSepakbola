using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Table.Master;

namespace WebTest.Data.Contract.Master
{
    public interface ITim
    {
        Task<bool> Simpan(Tim model);
        Task<List<Tim>> GetAll();
        Task<bool> Hapus(Tim model);
    }
}
