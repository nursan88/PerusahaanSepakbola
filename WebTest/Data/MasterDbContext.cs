using Microsoft.EntityFrameworkCore; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.Data.Table.Master;
using WebTest.Data.Table.Transaksi;

namespace WebTest.Data
{
    public class MasterDbContext : DbContext
    {
        //Master
        public DbSet<Pemain> Pemains { get; set; }
        public DbSet<Tim> Tims { get; set; }
        public DbSet<Posisi> Posisis { get; set; }
        public DbSet<PosisiPemain> PosisiPemains { get; set; }
        public DbSet<TimPemain> TimPemains { get; set; }

        //Transaksi
        public DbSet<HasilPertandingan> HasilPertandingans { get; set; }
        public DbSet<SkorHasil> SkorHasils { get; set; }
        public DbSet<JadwalPertandingan> JadwalPertandingans { get; set; }

        public MasterDbContext()
        {
        }
        public MasterDbContext(DbContextOptions<MasterDbContext> options)
       : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Master
            modelBuilder.Entity<Pemain>().HasKey(x => x.Id_pemain);
            modelBuilder.Entity<Pemain>().ToTable("MPemain");

            modelBuilder.Entity<Tim>().HasKey(x => x.Id_tim);
            modelBuilder.Entity<Tim>().ToTable("MTim");

            modelBuilder.Entity<Posisi>().HasKey(x => x.id_posisi);
            modelBuilder.Entity<Posisi>().ToTable("MPosisi");

            modelBuilder.Entity<PosisiPemain>().HasKey(x => x.Id);
            modelBuilder.Entity<PosisiPemain>().ToTable("MPosisiPemain");

            modelBuilder.Entity<TimPemain>().HasKey(x => x.Id);
            modelBuilder.Entity<TimPemain>().ToTable("MTimPemain");

            //Transaksi
            modelBuilder.Entity<HasilPertandingan>().HasKey(x => x.Id);
            modelBuilder.Entity<HasilPertandingan>().ToTable("HasilPertandingan");

            modelBuilder.Entity<JadwalPertandingan>().HasKey(x => x.id_jadwal);
            modelBuilder.Entity<JadwalPertandingan>().ToTable("JadwalPertandingan");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\ss2008r2;User Id=sa;Password=j4s4medik4;Database=PerusahaanXYZ;Persist Security Info=True;");
        }
    }
}
