using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Table.Master;

namespace WebTest.Data.Table.Transaksi
{
    public class JadwalPertandingan
    {
        public int id_jadwal { get; set; }
        public DateTime TanggalPertandingan { get; set; }
        public TimeSpan WaktuPertandingan { get; set; }
        public bool flag { get; set; }
        public Tim TimTuanRumah { get; set; }
        public long? TimTuanRumahId_tim { get; set; }
        public Tim TimTamu { get; set; }
        public long? TimTamuId_tim { get; set; }

    }
}
