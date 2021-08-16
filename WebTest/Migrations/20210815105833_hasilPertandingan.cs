using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class hasilPertandingan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimTamuId",
                table: "JadwalPertandingan");

            migrationBuilder.DropColumn(
                name: "TimTuanRumahId",
                table: "JadwalPertandingan");

            migrationBuilder.DropColumn(
                name: "Waktu_cetak_gol",
                table: "HasilPertandingan");

            migrationBuilder.RenameColumn(
                name: "id_team",
                table: "HasilPertandingan",
                newName: "SkorTimTuanRumah");

            migrationBuilder.RenameColumn(
                name: "id_pemain_cetak_skor",
                table: "HasilPertandingan",
                newName: "SkorTimTamu");

            migrationBuilder.RenameColumn(
                name: "TotalSkor",
                table: "HasilPertandingan",
                newName: "HasilSkor");

            migrationBuilder.RenameColumn(
                name: "id_hasilpertandingan",
                table: "HasilPertandingan",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "JadwalPertandinganid_jadwal",
                table: "HasilPertandingan",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SkorHasil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasilPertandinganId = table.Column<int>(type: "int", nullable: true),
                    TimId_tim1 = table.Column<long>(type: "bigint", nullable: true),
                    TimId_tim = table.Column<int>(type: "int", nullable: true),
                    PemainId_pemain = table.Column<int>(type: "int", nullable: true),
                    Skor = table.Column<int>(type: "int", nullable: false),
                    MenitSkor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkorHasil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkorHasil_HasilPertandingan_HasilPertandinganId",
                        column: x => x.HasilPertandinganId,
                        principalTable: "HasilPertandingan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkorHasil_MPemain_PemainId_pemain",
                        column: x => x.PemainId_pemain,
                        principalTable: "MPemain",
                        principalColumn: "Id_pemain",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkorHasil_MTim_TimId_tim1",
                        column: x => x.TimId_tim1,
                        principalTable: "MTim",
                        principalColumn: "Id_tim",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HasilPertandingan_JadwalPertandinganid_jadwal",
                table: "HasilPertandingan",
                column: "JadwalPertandinganid_jadwal");

            migrationBuilder.CreateIndex(
                name: "IX_SkorHasil_HasilPertandinganId",
                table: "SkorHasil",
                column: "HasilPertandinganId");

            migrationBuilder.CreateIndex(
                name: "IX_SkorHasil_PemainId_pemain",
                table: "SkorHasil",
                column: "PemainId_pemain");

            migrationBuilder.CreateIndex(
                name: "IX_SkorHasil_TimId_tim1",
                table: "SkorHasil",
                column: "TimId_tim1");

            migrationBuilder.AddForeignKey(
                name: "FK_HasilPertandingan_JadwalPertandingan_JadwalPertandinganid_jadwal",
                table: "HasilPertandingan",
                column: "JadwalPertandinganid_jadwal",
                principalTable: "JadwalPertandingan",
                principalColumn: "id_jadwal",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HasilPertandingan_JadwalPertandingan_JadwalPertandinganid_jadwal",
                table: "HasilPertandingan");

            migrationBuilder.DropTable(
                name: "SkorHasil");

            migrationBuilder.DropIndex(
                name: "IX_HasilPertandingan_JadwalPertandinganid_jadwal",
                table: "HasilPertandingan");

            migrationBuilder.DropColumn(
                name: "JadwalPertandinganid_jadwal",
                table: "HasilPertandingan");

            migrationBuilder.RenameColumn(
                name: "SkorTimTuanRumah",
                table: "HasilPertandingan",
                newName: "id_team");

            migrationBuilder.RenameColumn(
                name: "SkorTimTamu",
                table: "HasilPertandingan",
                newName: "id_pemain_cetak_skor");

            migrationBuilder.RenameColumn(
                name: "HasilSkor",
                table: "HasilPertandingan",
                newName: "TotalSkor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HasilPertandingan",
                newName: "id_hasilpertandingan");

            migrationBuilder.AddColumn<int>(
                name: "TimTamuId",
                table: "JadwalPertandingan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimTuanRumahId",
                table: "JadwalPertandingan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Waktu_cetak_gol",
                table: "HasilPertandingan",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
