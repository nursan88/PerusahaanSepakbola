using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class RelasiTim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MTimPemain_MTim_TimId_tim",
                table: "MTimPemain");

            migrationBuilder.RenameColumn(
                name: "TimId_tim",
                table: "MTimPemain",
                newName: "NamaTimId_tim");

            migrationBuilder.RenameColumn(
                name: "TimId",
                table: "MTimPemain",
                newName: "NamaTimId");

            migrationBuilder.RenameIndex(
                name: "IX_MTimPemain_TimId_tim",
                table: "MTimPemain",
                newName: "IX_MTimPemain_NamaTimId_tim");

            migrationBuilder.AddForeignKey(
                name: "FK_MTimPemain_MTim_NamaTimId_tim",
                table: "MTimPemain",
                column: "NamaTimId_tim",
                principalTable: "MTim",
                principalColumn: "Id_tim",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MTimPemain_MTim_NamaTimId_tim",
                table: "MTimPemain");

            migrationBuilder.RenameColumn(
                name: "NamaTimId_tim",
                table: "MTimPemain",
                newName: "TimId_tim");

            migrationBuilder.RenameColumn(
                name: "NamaTimId",
                table: "MTimPemain",
                newName: "TimId");

            migrationBuilder.RenameIndex(
                name: "IX_MTimPemain_NamaTimId_tim",
                table: "MTimPemain",
                newName: "IX_MTimPemain_TimId_tim");

            migrationBuilder.AddForeignKey(
                name: "FK_MTimPemain_MTim_TimId_tim",
                table: "MTimPemain",
                column: "TimId_tim",
                principalTable: "MTim",
                principalColumn: "Id_tim",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
