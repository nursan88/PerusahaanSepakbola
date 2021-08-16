using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.DataLog.Table.Delete
{
    public class DeleteJadwal
    {
        public int id_jadwal { get; set; }
        public DateTime WaktuPertandingan { get; set; }
        public int id_team_tuanrumah { get; set; }
        public int id_team_tamu { get; set; }
        public DateTime tgl_hapus { get; set; }
        public bool flag { get; set; }
    }
}
