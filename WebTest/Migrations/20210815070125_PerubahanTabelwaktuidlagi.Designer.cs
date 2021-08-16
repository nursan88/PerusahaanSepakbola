﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTest.Data;

namespace WebTest.Migrations
{
    [DbContext(typeof(MasterDbContext))]
    [Migration("20210815070125_PerubahanTabelwaktuidlagi")]
    partial class PerubahanTabelwaktuidlagi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("Id_team")
                        .HasColumnType("int");

                    b.Property<string>("NamaPemain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoPunggung")
                        .HasColumnType("int");

                    b.Property<int?>("PosisiPemainId")
                        .HasColumnType("int");

                    b.Property<int>("TinggiBadan")
                        .HasColumnType("int");

                    b.Property<bool>("flag")
                        .HasColumnType("bit");

                    b.HasKey("Id_pemain");

                    b.HasIndex("PosisiPemainId");

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

            modelBuilder.Entity("WebTest.Data.Table.Transaksi.HasilPertandingan", b =>
                {
                    b.Property<int>("id_hasilpertandingan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TotalSkor")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Waktu_cetak_gol")
                        .HasColumnType("time");

                    b.Property<bool>("flag")
                        .HasColumnType("bit");

                    b.Property<int>("id_pemain_cetak_skor")
                        .HasColumnType("int");

                    b.Property<int>("id_team")
                        .HasColumnType("int");

                    b.HasKey("id_hasilpertandingan");

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

                    b.Property<int?>("TimTamuId")
                        .HasColumnType("int");

                    b.Property<long?>("TimTamuId_tim")
                        .HasColumnType("bigint");

                    b.Property<int?>("TimTuanRumahId")
                        .HasColumnType("int");

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

            modelBuilder.Entity("WebTest.Data.Table.Master.Pemain", b =>
                {
                    b.HasOne("WebTest.Data.Table.Master.Posisi", "PosisiPemain")
                        .WithMany()
                        .HasForeignKey("PosisiPemainId");

                    b.Navigation("PosisiPemain");
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
#pragma warning restore 612, 618
        }
    }
}
