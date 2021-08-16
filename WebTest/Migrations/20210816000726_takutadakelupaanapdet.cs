using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class takutadakelupaanapdet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HasilPertandingan_JadwalPertandingan_JadwalPertandinganid_jadwal",
                table: "HasilPertandingan");

            migrationBuilder.DropForeignKey(
                name: "FK_SkorHasil_HasilPertandingan_HasilPertandinganId",
                table: "SkorHasil");

            migrationBuilder.DropForeignKey(
                name: "FK_SkorHasil_MPemain_PemainId_pemain",
                table: "SkorHasil");

            migrationBuilder.DropForeignKey(
                name: "FK_SkorHasil_MTim_TimId_tim1",
                table: "SkorHasil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkorHasil",
                table: "SkorHasil");

            migrationBuilder.RenameTable(
                name: "SkorHasil",
                newName: "SkorHasils");

            migrationBuilder.RenameIndex(
                name: "IX_SkorHasil_TimId_tim1",
                table: "SkorHasils",
                newName: "IX_SkorHasils_TimId_tim1");

            migrationBuilder.RenameIndex(
                name: "IX_SkorHasil_PemainId_pemain",
                table: "SkorHasils",
                newName: "IX_SkorHasils_PemainId_pemain");

            migrationBuilder.RenameIndex(
                name: "IX_SkorHasil_HasilPertandinganId",
                table: "SkorHasils",
                newName: "IX_SkorHasils_HasilPertandinganId");

            migrationBuilder.AlterColumn<int>(
                name: "JadwalPertandinganid_jadwal",
                table: "HasilPertandingan",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkorHasils",
                table: "SkorHasils",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HasilPertandingan_JadwalPertandingan_JadwalPertandinganid_jadwal",
                table: "HasilPertandingan",
                column: "JadwalPertandinganid_jadwal",
                principalTable: "JadwalPertandingan",
                principalColumn: "id_jadwal",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkorHasils_HasilPertandingan_HasilPertandinganId",
                table: "SkorHasils",
                column: "HasilPertandinganId",
                principalTable: "HasilPertandingan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkorHasils_MPemain_PemainId_pemain",
                table: "SkorHasils",
                column: "PemainId_pemain",
                principalTable: "MPemain",
                principalColumn: "Id_pemain",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkorHasils_MTim_TimId_tim1",
                table: "SkorHasils",
                column: "TimId_tim1",
                principalTable: "MTim",
                principalColumn: "Id_tim",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HasilPertandingan_JadwalPertandingan_JadwalPertandinganid_jadwal",
                table: "HasilPertandingan");

            migrationBuilder.DropForeignKey(
                name: "FK_SkorHasils_HasilPertandingan_HasilPertandinganId",
                table: "SkorHasils");

            migrationBuilder.DropForeignKey(
                name: "FK_SkorHasils_MPemain_PemainId_pemain",
                table: "SkorHasils");

            migrationBuilder.DropForeignKey(
                name: "FK_SkorHasils_MTim_TimId_tim1",
                table: "SkorHasils");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkorHasils",
                table: "SkorHasils");

            migrationBuilder.RenameTable(
                name: "SkorHasils",
                newName: "SkorHasil");

            migrationBuilder.RenameIndex(
                name: "IX_SkorHasils_TimId_tim1",
                table: "SkorHasil",
                newName: "IX_SkorHasil_TimId_tim1");

            migrationBuilder.RenameIndex(
                name: "IX_SkorHasils_PemainId_pemain",
                table: "SkorHasil",
                newName: "IX_SkorHasil_PemainId_pemain");

            migrationBuilder.RenameIndex(
                name: "IX_SkorHasils_HasilPertandinganId",
                table: "SkorHasil",
                newName: "IX_SkorHasil_HasilPertandinganId");

            migrationBuilder.AlterColumn<int>(
                name: "JadwalPertandinganid_jadwal",
                table: "HasilPertandingan",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkorHasil",
                table: "SkorHasil",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HasilPertandingan_JadwalPertandingan_JadwalPertandinganid_jadwal",
                table: "HasilPertandingan",
                column: "JadwalPertandinganid_jadwal",
                principalTable: "JadwalPertandingan",
                principalColumn: "id_jadwal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkorHasil_HasilPertandingan_HasilPertandinganId",
                table: "SkorHasil",
                column: "HasilPertandinganId",
                principalTable: "HasilPertandingan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkorHasil_MPemain_PemainId_pemain",
                table: "SkorHasil",
                column: "PemainId_pemain",
                principalTable: "MPemain",
                principalColumn: "Id_pemain",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkorHasil_MTim_TimId_tim1",
                table: "SkorHasil",
                column: "TimId_tim1",
                principalTable: "MTim",
                principalColumn: "Id_tim",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
