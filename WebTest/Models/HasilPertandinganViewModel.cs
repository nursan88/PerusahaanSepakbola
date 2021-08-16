using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Table.Master;
using WebTest.Data.Table.Transaksi;

namespace WebTest.Models
{
    public class HasilPertandinganViewModel
    {
        public int Id { get; set; }
        public JadwalPertandingan JadwalPertandingan { get; set; }
        public int JadwalPertandinganId { get; set; }
        public string HasilSkor { get; set; }
        public int SkorTimTamu { get; set; }
        public int SkorTimTuanRumah { get; set; }
        public List<SkorHasilViewModel> SkorPertandingan { get; set; }

    }
    public class SkorHasilViewModel
    {
        public int Id { get; set; }
        public HasilPertandinganViewModel HasilPertandingan { get; set; }
        public int? HasilPertandinganId { get; set; }
        public Tim Tim { get; set; }
        public int TimId { get; set; }
        public Pemain Pemain { get; set; }
        public int? PemainId { get; set; }
        public int Skor { get; set; }
        public int MenitSkor { get; set; }
    }
}
