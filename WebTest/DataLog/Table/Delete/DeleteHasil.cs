using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.DataLog.Table.Delete
{
    public class DeleteHasil
    {
        public int id_hasilpertandingan { get; set; }
        public int TotalSkor { get; set; }
        public int id_pemain_cetak_skor { get; set; }
        public int id_team { get; set; }
        public TimeSpan Waktu_cetak_gol { get; set; }
        public DateTime tgl_hapus { get; set; }
        public bool flag { get; set; }
    }
}
