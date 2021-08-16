using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.DataLog.Table.Delete
{
    public class DeletePemain
    {
        public int Id_pemain { get; set; }
        public int Id_team { get; set; }
        public string NamaPemain { get; set; }
        public int TinggiBadan { get; set; }
        public int BeratBadan { get; set; }
        public int id_posisi { get; set; }
        public int NoPunggung { get; set; }
        public DateTime tgl_hapus { get; set; }
        public bool flag { get; set; }
    }
}
