using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Table.Master;

namespace WebTest.Data.Contract.Master
{
    public interface IPosisi
    {
        Task<bool> Simpan(Posisi model);
        Task<List<Posisi>> GetAll();
        Task<bool> Hapus(Posisi model);
    }
}
