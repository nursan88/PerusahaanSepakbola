using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations.LogDb
{
    public partial class Tambahkolomflagdisemuatabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Flag",
                table: "DeleteTim",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "flag",
                table: "DeletePosisi",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "flag",
                table: "DeletePemain",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "flag",
                table: "DeleteJadwal",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "flag",
                table: "DeleteHasil",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Flag",
                table: "DeleteTim");

            migrationBuilder.DropColumn(
                name: "flag",
                table: "DeletePosisi");

            migrationBuilder.DropColumn(
                name: "flag",
                table: "DeletePemain");

            migrationBuilder.DropColumn(
                name: "flag",
                table: "DeleteJadwal");

            migrationBuilder.DropColumn(
                name: "flag",
                table: "DeleteHasil");
        }
    }
}
