using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Table.Master;

namespace WebTest.Data.Contract.Master
{
    public interface ITimPemain
    {
        Task<TimPemain> Simpan(TimPemain model);
        Task<List<TimPemain>> GetAll();
    }
}
