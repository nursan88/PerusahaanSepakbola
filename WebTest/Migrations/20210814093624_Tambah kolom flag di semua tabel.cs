using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class Tambahkolomflagdisemuatabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "flag",
                table: "MTim",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "flag",
                table: "MPosisi",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "flag",
                table: "MPemain",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "flag",
                table: "JadwalPertandingan",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "flag",
                table: "HasilPertandingan",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "flag",
                table: "MTim");

            migrationBuilder.DropColumn(
                name: "flag",
                table: "MPosisi");

            migrationBuilder.DropColumn(
                name: "flag",
                table: "MPemain");

            migrationBuilder.DropColumn(
                name: "flag",
                table: "JadwalPertandingan");

            migrationBuilder.DropColumn(
                name: "flag",
                table: "HasilPertandingan");
        }
    }
}
