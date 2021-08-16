using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class PerubahanTabelwaktuidlagi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "WaktuPertandingan",
                table: "JadwalPertandingan",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalPertandingan",
                table: "JadwalPertandingan",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TanggalPertandingan",
                table: "JadwalPertandingan");

            migrationBuilder.AlterColumn<DateTime>(
                name: "WaktuPertandingan",
                table: "JadwalPertandingan",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");
        }
    }
}
