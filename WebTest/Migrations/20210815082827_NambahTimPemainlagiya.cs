using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class NambahTimPemainlagiya : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPemain_MTim_NamaTimId_tim",
                table: "MPemain");

            migrationBuilder.DropForeignKey(
                name: "FK_MTimPemain_MPemain_PemainId",
                table: "MTimPemain");

            migrationBuilder.DropForeignKey(
                name: "FK_MTimPemain_MTim_NamaTimId_tim",
                table: "MTimPemain");

            migrationBuilder.DropIndex(
                name: "IX_MTimPemain_PemainId",
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

            migrationBuilder.RenameColumn(
                name: "NamaTimId_tim",
                table: "MPemain",
                newName: "TimPemainId_tim");

            migrationBuilder.RenameColumn(
                name: "NamaTimId",
                table: "MPemain",
                newName: "TimPemainId");

            migrationBuilder.RenameIndex(
                name: "IX_MPemain_NamaTimId_tim",
                table: "MPemain",
                newName: "IX_MPemain_TimPemainId_tim");

            migrationBuilder.AddColumn<int>(
                name: "PemainId_pemain",
                table: "MTimPemain",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MTimPemain_PemainId_pemain",
                table: "MTimPemain",
                column: "PemainId_pemain");

            migrationBuilder.AddForeignKey(
                name: "FK_MPemain_MTim_TimPemainId_tim",
                table: "MPemain",
                column: "TimPemainId_tim",
                principalTable: "MTim",
                principalColumn: "Id_tim",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MTimPemain_MPemain_PemainId_pemain",
                table: "MTimPemain",
                column: "PemainId_pemain",
                principalTable: "MPemain",
                principalColumn: "Id_pemain",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MTimPemain_MTim_TimId_tim",
                table: "MTimPemain",
                column: "TimId_tim",
                principalTable: "MTim",
                principalColumn: "Id_tim",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPemain_MTim_TimPemainId_tim",
                table: "MPemain");

            migrationBuilder.DropForeignKey(
                name: "FK_MTimPemain_MPemain_PemainId_pemain",
                table: "MTimPemain");

            migrationBuilder.DropForeignKey(
                name: "FK_MTimPemain_MTim_TimId_tim",
                table: "MTimPemain");

            migrationBuilder.DropIndex(
                name: "IX_MTimPemain_PemainId_pemain",
                table: "MTimPemain");

            migrationBuilder.DropColumn(
                name: "PemainId_pemain",
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

            migrationBuilder.RenameColumn(
                name: "TimPemainId_tim",
                table: "MPemain",
                newName: "NamaTimId_tim");

            migrationBuilder.RenameColumn(
                name: "TimPemainId",
                table: "MPemain",
                newName: "NamaTimId");

            migrationBuilder.RenameIndex(
                name: "IX_MPemain_TimPemainId_tim",
                table: "MPemain",
                newName: "IX_MPemain_NamaTimId_tim");

            migrationBuilder.CreateIndex(
                name: "IX_MTimPemain_PemainId",
                table: "MTimPemain",
                column: "PemainId");

            migrationBuilder.AddForeignKey(
                name: "FK_MPemain_MTim_NamaTimId_tim",
                table: "MPemain",
                column: "NamaTimId_tim",
                principalTable: "MTim",
                principalColumn: "Id_tim",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MTimPemain_MPemain_PemainId",
                table: "MTimPemain",
                column: "PemainId",
                principalTable: "MPemain",
                principalColumn: "Id_pemain",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MTimPemain_MTim_NamaTimId_tim",
                table: "MTimPemain",
                column: "NamaTimId_tim",
                principalTable: "MTim",
                principalColumn: "Id_tim",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
