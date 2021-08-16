using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class PerubahanPosisiPemain1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPosisiPemain_MPemain_PemainId",
                table: "MPosisiPemain");

            migrationBuilder.DropIndex(
                name: "IX_MPosisiPemain_PemainId",
                table: "MPosisiPemain");

            migrationBuilder.RenameColumn(
                name: "id_posisi",
                table: "MPemain",
                newName: "PosisiPemainId");

            migrationBuilder.AddColumn<int>(
                name: "PemainId_pemain",
                table: "MPosisiPemain",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MPosisiPemain_PemainId_pemain",
                table: "MPosisiPemain",
                column: "PemainId_pemain");

            migrationBuilder.CreateIndex(
                name: "IX_MPemain_PosisiPemainId",
                table: "MPemain",
                column: "PosisiPemainId");

            migrationBuilder.AddForeignKey(
                name: "FK_MPemain_MPosisi_PosisiPemainId",
                table: "MPemain",
                column: "PosisiPemainId",
                principalTable: "MPosisi",
                principalColumn: "id_posisi",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MPosisiPemain_MPemain_PemainId_pemain",
                table: "MPosisiPemain",
                column: "PemainId_pemain",
                principalTable: "MPemain",
                principalColumn: "Id_pemain",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPemain_MPosisi_PosisiPemainId",
                table: "MPemain");

            migrationBuilder.DropForeignKey(
                name: "FK_MPosisiPemain_MPemain_PemainId_pemain",
                table: "MPosisiPemain");

            migrationBuilder.DropIndex(
                name: "IX_MPosisiPemain_PemainId_pemain",
                table: "MPosisiPemain");

            migrationBuilder.DropIndex(
                name: "IX_MPemain_PosisiPemainId",
                table: "MPemain");

            migrationBuilder.DropColumn(
                name: "PemainId_pemain",
                table: "MPosisiPemain");

            migrationBuilder.RenameColumn(
                name: "PosisiPemainId",
                table: "MPemain",
                newName: "id_posisi");

            migrationBuilder.CreateIndex(
                name: "IX_MPosisiPemain_PemainId",
                table: "MPosisiPemain",
                column: "PemainId");

            migrationBuilder.AddForeignKey(
                name: "FK_MPosisiPemain_MPemain_PemainId",
                table: "MPosisiPemain",
                column: "PemainId",
                principalTable: "MPemain",
                principalColumn: "Id_pemain",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
