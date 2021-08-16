using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.DataLog.Table.Delete
{
    public class DeleteTim
    {
        public long Id_tim { get; set; }
        public string NamaTim { get; set; }
        public string LogoTim { get; set; }
        public int TahunBerdiri { get; set; }
        public string AlamatTim { get; set; }
        public string KotaTim { get; set; }
        public DateTime tgl_hapus { get; set; }
        public bool Flag { get; set; }
    }
}
