using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Table.Transaksi;

namespace WebTest.Data.Contract.Transaksi
{
    public interface IHasilPertandingan
    {
        Task<HasilPertandingan> Simpan(HasilPertandingan model);
        Task<List<HasilPertandingan>> GetAll();
        Task<bool> Hapus(HasilPertandingan model);
    }
}
