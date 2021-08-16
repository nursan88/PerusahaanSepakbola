using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class sajdhaskdhsakjdh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPemain_MTim_TimPemainId_tim",
                table: "MPemain");

            migrationBuilder.DropForeignKey(
                name: "FK_MTimPemain_MPemain_PemainId_pemain",
                table: "MTimPemain");

            migrationBuilder.DropIndex(
                name: "IX_MTimPemain_PemainId_pemain",
                table: "MTimPemain");

            migrationBuilder.DropIndex(
                name: "IX_MPemain_TimPemainId_tim",
                table: "MPemain");

            migrationBuilder.DropColumn(
                name: "PemainId_pemain",
                table: "MTimPemain");

            migrationBuilder.DropColumn(
                name: "TimPemainId",
                table: "MPemain");

            migrationBuilder.AlterColumn<int>(
                name: "TimPemainId_tim",
                table: "MPemain",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TimPemainId_tim1",
                table: "MPemain",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MTimPemain_PemainId",
                table: "MTimPemain",
                column: "PemainId");

            migrationBuilder.CreateIndex(
                name: "IX_MPemain_TimPemainId_tim1",
                table: "MPemain",
                column: "TimPemainId_tim1");

            migrationBuilder.AddForeignKey(
                name: "FK_MPemain_MTim_TimPemainId_tim1",
                table: "MPemain",
                column: "TimPemainId_tim1",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPemain_MTim_TimPemainId_tim1",
                table: "MPemain");

            migrationBuilder.DropForeignKey(
                name: "FK_MTimPemain_MPemain_PemainId",
                table: "MTimPemain");

            migrationBuilder.DropIndex(
                name: "IX_MTimPemain_PemainId",
                table: "MTimPemain");

            migrationBuilder.DropIndex(
                name: "IX_MPemain_TimPemainId_tim1",
                table: "MPemain");

            migrationBuilder.DropColumn(
                name: "TimPemainId_tim1",
                table: "MPemain");

            migrationBuilder.AddColumn<int>(
                name: "PemainId_pemain",
                table: "MTimPemain",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "TimPemainId_tim",
                table: "MPemain",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimPemainId",
                table: "MPemain",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MTimPemain_PemainId_pemain",
                table: "MTimPemain",
                column: "PemainId_pemain");

            migrationBuilder.CreateIndex(
                name: "IX_MPemain_TimPemainId_tim",
                table: "MPemain",
                column: "TimPemainId_tim");

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
        }
    }
}
