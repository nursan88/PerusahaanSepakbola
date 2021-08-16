using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Data.Table.Master
{
    public class Pemain
    {
        public int Id_pemain { get; set; }
        public string NamaPemain { get; set; }
        public int TinggiBadan { get; set; }
        public int BeratBadan { get; set; }
        public int NoPunggung { get; set; }
        public bool flag { get; set; }
        public Tim TimPemain { get; set; }
        public long? TimPemainId_tim { get; set; }
        public Posisi PosisiPemain { get; set; }
        public int? PosisiPemainId { get; set; }
    }
}
