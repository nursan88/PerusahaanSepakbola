using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.DataLog.Table.Delete;

namespace WebTest.DataLog.Contract.Delete
{
    interface IDeleteHasil
    {
        Task<bool> Simpan(DeleteHasil model);
        //Task<List<DeleteHasil>> GetAll();
    }
}
