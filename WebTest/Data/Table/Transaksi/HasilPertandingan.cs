using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Data.Table.Transaksi
{
    public class HasilPertandingan
    {
        public int Id { get; set; }
        public JadwalPertandingan JadwalPertandingan { get; set; }
        public int JadwalPertandinganid_jadwal { get; set; } 
        public int HasilSkor { get; set; }
        public int SkorTimTamu { get; set; }
        public int SkorTimTuanRumah { get; set; }
        public List<SkorHasil> SkorPertandingan { get; set; }
        public bool flag { get; set; }
    }
}
