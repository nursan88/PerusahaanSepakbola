using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Table.Master;

namespace WebTest.Data.Contract.Master
{
    public interface IPemain
    {
        Task<bool> CheckNo(int no, int timId);
        Task<Pemain> Simpan(Pemain model);
        Task<List<Pemain>> GetAll();
        Task<Pemain> Hapus(Pemain model);
        Task<List<Pemain>> GetPemainByTimId(int timId);
    }
}
