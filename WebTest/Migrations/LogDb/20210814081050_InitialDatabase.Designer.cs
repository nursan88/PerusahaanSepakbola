﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTest.Data;
using WebTest.DataLog;

namespace WebTest.Migrations.LogDb
{
    [DbContext(typeof(LogDbContext))]
    [Migration("20210814081050_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebTest.Data.Table.Delete.DeleteHasil", b =>
                {
                    b.Property<int>("id_hasilpertandingan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TotalSkor")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Waktu_cetak_gol")
                        .HasColumnType("time");

                    b.Property<int>("id_pemain_cetak_skor")
                        .HasColumnType("int");

                    b.Property<int>("id_team")
                        .HasColumnType("int");

                    b.Property<DateTime>("tgl_hapus")
                        .HasColumnType("datetime2");

                    b.HasKey("id_hasilpertandingan");

                    b.ToTable("DeleteHasil");
                });

            modelBuilder.Entity("WebTest.Data.Table.Delete.DeleteJadwal", b =>
                {
                    b.Property<int>("id_jadwal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("WaktuPertandingan")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_team_tamu")
                        .HasColumnType("int");

                    b.Property<int>("id_team_tuanrumah")
                        .HasColumnType("int");

                    b.Property<DateTime>("tgl_hapus")
                        .HasColumnType("datetime2");

                    b.HasKey("id_jadwal");

                    b.ToTable("DeleteJadwal");
                });

            modelBuilder.Entity("WebTest.Data.Table.Delete.DeletePemain", b =>
                {
                    b.Property<int>("Id_pemain")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BeratBadan")
                        .HasColumnType("int");

                    b.Property<int>("Id_team")
                        .HasColumnType("int");

                    b.Property<string>("NamaPemain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoPunggung")
                        .HasColumnType("int");

                    b.Property<int>("TinggiBadan")
                        .HasColumnType("int");

                    b.Property<int>("id_posisi")
                        .HasColumnType("int");

                    b.Property<DateTime>("tgl_hapus")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_pemain");

                    b.ToTable("DeletePemain");
                });

            modelBuilder.Entity("WebTest.Data.Table.Delete.DeletePosisi", b =>
                {
                    b.Property<int>("id_posisi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PosisiPemain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusEnabled")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("tgl_hapus")
                        .HasColumnType("datetime2");

                    b.HasKey("id_posisi");

                    b.ToTable("DeletePosisi");
                });

            modelBuilder.Entity("WebTest.Data.Table.Delete.DeleteTim", b =>
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

                    b.Property<DateTime>("tgl_hapus")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_tim");

                    b.ToTable("DeleteTim");
                });
#pragma warning restore 612, 618
        }
    }
}
