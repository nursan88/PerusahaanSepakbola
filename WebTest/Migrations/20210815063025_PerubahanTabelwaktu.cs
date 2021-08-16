using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class PerubahanTabelwaktu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_team_tamu",
                table: "JadwalPertandingan");

            migrationBuilder.DropColumn(
                name: "id_team_tuanrumah",
                table: "JadwalPertandingan");

            migrationBuilder.AddColumn<long>(
                name: "TimTamuId_tim",
                table: "JadwalPertandingan",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimTamuhId",
                table: "JadwalPertandingan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimTuanRumahId",
                table: "JadwalPertandingan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TimTuanRumahId_tim",
                table: "JadwalPertandingan",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JadwalPertandingan_TimTamuId_tim",
                table: "JadwalPertandingan",
                column: "TimTamuId_tim");

            migrationBuilder.CreateIndex(
                name: "IX_JadwalPertandingan_TimTuanRumahId_tim",
                table: "JadwalPertandingan",
                column: "TimTuanRumahId_tim");

            migrationBuilder.AddForeignKey(
                name: "FK_JadwalPertandingan_MTim_TimTamuId_tim",
                table: "JadwalPertandingan",
                column: "TimTamuId_tim",
                principalTable: "MTim",
                principalColumn: "Id_tim",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JadwalPertandingan_MTim_TimTuanRumahId_tim",
                table: "JadwalPertandingan",
                column: "TimTuanRumahId_tim",
                principalTable: "MTim",
                principalColumn: "Id_tim",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JadwalPertandingan_MTim_TimTamuId_tim",
                table: "JadwalPertandingan");

            migrationBuilder.DropForeignKey(
                name: "FK_JadwalPertandingan_MTim_TimTuanRumahId_tim",
                table: "JadwalPertandingan");

            migrationBuilder.DropIndex(
                name: "IX_JadwalPertandingan_TimTamuId_tim",
                table: "JadwalPertandingan");

            migrationBuilder.DropIndex(
                name: "IX_JadwalPertandingan_TimTuanRumahId_tim",
                table: "JadwalPertandingan");

            migrationBuilder.DropColumn(
                name: "TimTamuId_tim",
                table: "JadwalPertandingan");

            migrationBuilder.DropColumn(
                name: "TimTamuhId",
                table: "JadwalPertandingan");

            migrationBuilder.DropColumn(
                name: "TimTuanRumahId",
                table: "JadwalPertandingan");

            migrationBuilder.DropColumn(
                name: "TimTuanRumahId_tim",
                table: "JadwalPertandingan");

            migrationBuilder.AddColumn<int>(
                name: "id_team_tamu",
                table: "JadwalPertandingan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_team_tuanrumah",
                table: "JadwalPertandingan",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
