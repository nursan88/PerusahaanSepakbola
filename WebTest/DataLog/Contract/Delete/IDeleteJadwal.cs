using System;
using System.Collections.Generic;
using System.Linq;
using WebTest.DataLog.Table.Delete;
using System.Threading.Tasks;

namespace WebTest.DataLog.Contract.Delete
{
    interface IDeleteJadwal
    {
        Task<bool> Simpan(DeleteJadwal model);
    }
}
