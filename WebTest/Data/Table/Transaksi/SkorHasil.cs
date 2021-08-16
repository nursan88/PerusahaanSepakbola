using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Table.Master;

namespace WebTest.Data.Table.Transaksi
{
    public class SkorHasil
    {
        public int Id { get; set; }
        public HasilPertandingan HasilPertandingan { get; set; }
        public int? HasilPertandinganId { get; set; }
        public Tim Tim { get; set; }
        public long? TimId_tim { get; set; }
        public Pemain Pemain { get; set; }
        public int? PemainId_pemain { get; set; }
        public int Skor { get; set; }
        public int MenitSkor { get; set; }
    }
}
