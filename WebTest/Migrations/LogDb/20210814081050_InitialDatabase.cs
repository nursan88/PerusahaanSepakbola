using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations.LogDb
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeleteHasil",
                columns: table => new
                {
                    id_hasilpertandingan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalSkor = table.Column<int>(type: "int", nullable: false),
                    id_pemain_cetak_skor = table.Column<int>(type: "int", nullable: false),
                    id_team = table.Column<int>(type: "int", nullable: false),
                    Waktu_cetak_gol = table.Column<TimeSpan>(type: "time", nullable: false),
                    tgl_hapus = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeleteHasil", x => x.id_hasilpertandingan);
                });

            migrationBuilder.CreateTable(
                name: "DeleteJadwal",
                columns: table => new
                {
                    id_jadwal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WaktuPertandingan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_team_tuanrumah = table.Column<int>(type: "int", nullable: false),
                    id_team_tamu = table.Column<int>(type: "int", nullable: false),
                    tgl_hapus = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeleteJadwal", x => x.id_jadwal);
                });

            migrationBuilder.CreateTable(
                name: "DeletePemain",
                columns: table => new
                {
                    Id_pemain = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_team = table.Column<int>(type: "int", nullable: false),
                    NamaPemain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinggiBadan = table.Column<int>(type: "int", nullable: false),
                    BeratBadan = table.Column<int>(type: "int", nullable: false),
                    id_posisi = table.Column<int>(type: "int", nullable: false),
                    NoPunggung = table.Column<int>(type: "int", nullable: false),
                    tgl_hapus = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeletePemain", x => x.Id_pemain);
                });

            migrationBuilder.CreateTable(
                name: "DeletePosisi",
                columns: table => new
                {
                    id_posisi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosisiPemain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusEnabled = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tgl_hapus = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeletePosisi", x => x.id_posisi);
                });

            migrationBuilder.CreateTable(
                name: "DeleteTim",
                columns: table => new
                {
                    Id_tim = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaTim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoTim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TahunBerdiri = table.Column<int>(type: "int", nullable: false),
                    AlamatTim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KotaTim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tgl_hapus = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeleteTim", x => x.Id_tim);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeleteHasil");

            migrationBuilder.DropTable(
                name: "DeleteJadwal");

            migrationBuilder.DropTable(
                name: "DeletePemain");

            migrationBuilder.DropTable(
                name: "DeletePosisi");

            migrationBuilder.DropTable(
                name: "DeleteTim");
        }
    }
}
