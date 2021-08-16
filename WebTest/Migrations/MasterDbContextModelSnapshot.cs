﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTest.Data;

namespace WebTest.Migrations
{
    [DbContext(typeof(MasterDbContext))]
    partial class MasterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebTest.Data.Table.Master.Pemain", b =>
                {
                    b.Property<int>("Id_pemain")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BeratBadan")
                        .HasColumnType("int");

                    b.Property<string>("NamaPemain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoPunggung")
                        .HasColumnType("int");

                    b.Property<int?>("PosisiPemainId")
                        .HasColumnType("int");

                    b.Property<long?>("TimPemainId_tim")
                        .HasColumnType("bigint");

                    b.Property<int>("TinggiBadan")
                        .HasColumnType("int");

                    b.Property<bool>("flag")
                        .HasColumnType("bit");

                    b.HasKey("Id_pemain");

                    b.HasIndex("PosisiPemainId");

                    b.HasIndex("TimPemainId_tim");

                    b.ToTable("MPemain");
                });

            modelBuilder.Entity("WebTest.Data.Table.Master.Posisi", b =>
                {
                    b.Property<int>("id_posisi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PosisiPemain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusEnabled")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("flag")
                        .HasColumnType("bit");

                    b.HasKey("id_posisi");

                    b.ToTable("MPosisi");
                });

            modelBuilder.Entity("WebTest.Data.Table.Master.PosisiPemain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PemainId")
                        .HasColumnType("int");

                    b.Property<int?>("PemainId_pemain")
                        .HasColumnType("int");

                    b.Property<int?>("PosisiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PemainId_pemain");

                    b.HasIndex("PosisiId");

                    b.ToTable("MPosisiPemain");
                });

            modelBuilder.Entity("WebTest.Data.Table.Master.Tim", b =>
                {
                    b.Property<long>("Id_tim")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlamatTim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KotaTim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoTim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaTim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TahunBerdiri")
                        .HasColumnType("int");

                    b.Property<bool>("flag")
                        .HasColumnType("bit");

                    b.HasKey("Id_tim");

                    b.ToTable("MTim");
                });

            modelBuilder.Entity("WebTest.Data.Table.Master.TimPemain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NamaTimId")
                        .HasColumnType("int");

                    b.Property<long?>("NamaTimId_tim")
                        .HasColumnType("bigint");

                    b.Property<int?>("PemainId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NamaTimId_tim");

                    b.HasIndex("PemainId");

                    b.ToTable("MTimPemain");
                });

            modelBuilder.Entity("WebTest.Data.Table.Transaksi.HasilPertandingan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HasilSkor")
                        .HasColumnType("int");

                    b.Property<int>("JadwalPertandinganid_jadwal")
                        .HasColumnType("int");

                    b.Property<int>("SkorTimTamu")
                        .HasColumnType("int");

                    b.Property<int>("SkorTimTuanRumah")
                        .HasColumnType("int");

                    b.Property<bool>("flag")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("JadwalPertandinganid_jadwal");

                    b.ToTable("HasilPertandingan");
                });

            modelBuilder.Entity("WebTest.Data.Table.Transaksi.JadwalPertandingan", b =>
                {
                    b.Property<int>("id_jadwal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TanggalPertandingan")
                        .HasColumnType("datetime2");

                    b.Property<long?>("TimTamuId_tim")
                        .HasColumnType("bigint");

                    b.Property<long?>("TimTuanRumahId_tim")
                        .HasColumnType("bigint");

                    b.Property<TimeSpan>("WaktuPertandingan")
                        .HasColumnType("time");

                    b.Property<bool>("flag")
                        .HasColumnType("bit");

                    b.HasKey("id_jadwal");

                    b.HasIndex("TimTamuId_tim");

                    b.HasIndex("TimTuanRumahId_tim");

                    b.ToTable("JadwalPertandingan");
                });

            modelBuilder.Entity("WebTest.Data.Table.Transaksi.SkorHasil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HasilPertandinganId")
                        .HasColumnType("int");

                    b.Property<int>("MenitSkor")
                        .HasColumnType("int");

                    b.Property<int?>("PemainId_pemain")
                        .HasColumnType("int");

                    b.Property<int>("Skor")
                        .HasColumnType("int");

                    b.Property<long?>("TimId_tim")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("HasilPertandinganId");

                    b.HasIndex("PemainId_pemain");

                    b.HasIndex("TimId_tim");

                    b.ToTable("SkorHasils");
                });

            modelBuilder.Entity("WebTest.Data.Table.Master.Pemain", b =>
                {
                    b.HasOne("WebTest.Data.Table.Master.Posisi", "PosisiPemain")
                        .WithMany()
                        .HasForeignKey("PosisiPemainId");

                    b.HasOne("WebTest.Data.Table.Master.Tim", "TimPemain")
                        .WithMany()
                        .HasForeignKey("TimPemainId_tim");

                    b.Navigation("PosisiPemain");

                    b.Navigation("TimPemain");
                });

            modelBuilder.Entity("WebTest.Data.Table.Master.PosisiPemain", b =>
                {
                    b.HasOne("WebTest.Data.Table.Master.Pemain", "Pemain")
                        .WithMany()
                        .HasForeignKey("PemainId_pemain");

                    b.HasOne("WebTest.Data.Table.Master.Posisi", "Posisi")
                        .WithMany()
                        .HasForeignKey("PosisiId");

                    b.Navigation("Pemain");

                    b.Navigation("Posisi");
                });

            modelBuilder.Entity("WebTest.Data.Table.Master.TimPemain", b =>
                {
                    b.HasOne("WebTest.Data.Table.Master.Tim", "NamaTim")
                        .WithMany()
                        .HasForeignKey("NamaTimId_tim");

                    b.HasOne("WebTest.Data.Table.Master.Pemain", "Pemain")
                        .WithMany()
                        .HasForeignKey("PemainId");

                    b.Navigation("NamaTim");

                    b.Navigation("Pemain");
                });

            modelBuilder.Entity("WebTest.Data.Table.Transaksi.HasilPertandingan", b =>
                {
                    b.HasOne("WebTest.Data.Table.Transaksi.JadwalPertandingan", "JadwalPertandingan")
                        .WithMany()
                        .HasForeignKey("JadwalPertandinganid_jadwal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JadwalPertandingan");
                });

            modelBuilder.Entity("WebTest.Data.Table.Transaksi.JadwalPertandingan", b =>
                {
                    b.HasOne("WebTest.Data.Table.Master.Tim", "TimTamu")
                        .WithMany()
                        .HasForeignKey("TimTamuId_tim");

                    b.HasOne("WebTest.Data.Table.Master.Tim", "TimTuanRumah")
                        .WithMany()
                        .HasForeignKey("TimTuanRumahId_tim");

                    b.Navigation("TimTamu");

                    b.Navigation("TimTuanRumah");
                });

            modelBuilder.Entity("WebTest.Data.Table.Transaksi.SkorHasil", b =>
                {
                    b.HasOne("WebTest.Data.Table.Transaksi.HasilPertandingan", "HasilPertandingan")
                        .WithMany("SkorPertandingan")
                        .HasForeignKey("HasilPertandinganId");

                    b.HasOne("WebTest.Data.Table.Master.Pemain", "Pemain")
                        .WithMany()
                        .HasForeignKey("PemainId_pemain");

                    b.HasOne("WebTest.Data.Table.Master.Tim", "Tim")
                        .WithMany()
                        .HasForeignKey("TimId_tim");

                    b.Navigation("HasilPertandingan");

                    b.Navigation("Pemain");

                    b.Navigation("Tim");
                });

            modelBuilder.Entity("WebTest.Data.Table.Transaksi.HasilPertandingan", b =>
                {
                    b.Navigation("SkorPertandingan");
                });
#pragma warning restore 612, 618
        }
    }
}
