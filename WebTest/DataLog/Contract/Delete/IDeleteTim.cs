using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.DataLog.Table.Delete;

namespace WebTest.DataLog.Contract.Delete
{
    interface IDeleteTim
    {
        Task<bool> Simpan(DeleteTim model);
    }
}
