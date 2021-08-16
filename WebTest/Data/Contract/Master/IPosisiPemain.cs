using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Table.Master;

namespace WebTest.Data.Contract.Master
{
    public interface IPosisiPemain
    {
        Task<PosisiPemain> Simpan(PosisiPemain model);
        Task<List<PosisiPemain>> GetAll();
    }
}
