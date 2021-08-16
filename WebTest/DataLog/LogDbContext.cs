using Microsoft.EntityFrameworkCore; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTest.DataLog.Table.Delete;

namespace WebTest.DataLog
{
    public class LogDbContext : DbContext
    {
        //Delete
        public DbSet<DeleteHasil> DeleteHasils { get; set; }
        public DbSet<DeleteJadwal> DeleteJadwals { get; set; }
        public DbSet<DeletePemain> DeletePemains { get; set; }
        public DbSet<DeleteTim> DeleteTims { get; set; }
        public DbSet<DeletePosisi> DeletePosisis { get; set; }

        public LogDbContext()
        {
        }
        public LogDbContext(DbContextOptions<LogDbContext> options)
       : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Master
            modelBuilder.Entity<DeletePosisi>().HasKey(x => x.id_posisi);
            modelBuilder.Entity<DeletePosisi>().ToTable("DeletePosisi");

            modelBuilder.Entity<DeletePemain>().HasKey(x => x.Id_pemain);
            modelBuilder.Entity<DeletePemain>().ToTable("DeletePemain");

            modelBuilder.Entity<DeleteJadwal>().HasKey(x => x.id_jadwal);
            modelBuilder.Entity<DeleteJadwal>().ToTable("DeleteJadwal");

            modelBuilder.Entity<DeleteHasil>().HasKey(x => x.id_hasilpertandingan);
            modelBuilder.Entity<DeleteHasil>().ToTable("DeleteHasil");

            modelBuilder.Entity<DeleteTim>().HasKey(x => x.Id_tim);
            modelBuilder.Entity<DeleteTim>().ToTable("DeleteTim");


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\ss2008r2;User Id=sa;Password=j4s4medik4;Database=LogPerusahaanXYZ;Persist Security Info=True;");
        }
    }
}
