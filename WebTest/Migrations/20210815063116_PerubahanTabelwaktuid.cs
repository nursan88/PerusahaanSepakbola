using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class PerubahanTabelwaktuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimTamuhId",
                table: "JadwalPertandingan",
                newName: "TimTamuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimTamuId",
                table: "JadwalPertandingan",
                newName: "TimTamuhId");
        }
    }
}
