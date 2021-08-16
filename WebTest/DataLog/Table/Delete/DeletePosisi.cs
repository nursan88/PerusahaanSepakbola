using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.DataLog.Table.Delete
{
    public class DeletePosisi
    {
        public int id_posisi { get; set; }
        public string PosisiPemain { get; set; }
        public string StatusEnabled { get; set; }
        public DateTime tgl_hapus { get; set; }
        public bool flag { get; set; }
    }
}
