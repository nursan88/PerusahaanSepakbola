using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class cekdetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkorHasils_MTim_TimId_tim1",
                table: "SkorHasils");

            migrationBuilder.DropIndex(
                name: "IX_SkorHasils_TimId_tim1",
                table: "SkorHasils");

            migrationBuilder.DropColumn(
                name: "TimId_tim1",
                table: "SkorHasils");

            migrationBuilder.AlterColumn<long>(
                name: "TimId_tim",
                table: "SkorHasils",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SkorHasils_TimId_tim",
                table: "SkorHasils",
                column: "TimId_tim");

            migrationBuilder.AddForeignKey(
                name: "FK_SkorHasils_MTim_TimId_tim",
                table: "SkorHasils",
                column: "TimId_tim",
                principalTable: "MTim",
                principalColumn: "Id_tim",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkorHasils_MTim_TimId_tim",
                table: "SkorHasils");

            migrationBuilder.DropIndex(
                name: "IX_SkorHasils_TimId_tim",
                table: "SkorHasils");

            migrationBuilder.AlterColumn<int>(
                name: "TimId_tim",
                table: "SkorHasils",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TimId_tim1",
                table: "SkorHasils",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SkorHasils_TimId_tim1",
                table: "SkorHasils",
                column: "TimId_tim1");

            migrationBuilder.AddForeignKey(
                name: "FK_SkorHasils_MTim_TimId_tim1",
                table: "SkorHasils",
                column: "TimId_tim1",
                principalTable: "MTim",
                principalColumn: "Id_tim",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
