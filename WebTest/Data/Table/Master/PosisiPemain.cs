using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Data.Table.Master
{
    public class PosisiPemain
    {
        public int Id { get; set; }
        public Pemain Pemain { get; set; }//Harus inisiasi ini 
        public int? PemainId { get; set; }//ini relasi ke Pemain
        public Posisi Posisi { get; set; }
        public int? PosisiId { get; set; }//Nama Relasi Id atau foreign key harus sama sama yang di atasnya baru dtambahin Id
    }
}
