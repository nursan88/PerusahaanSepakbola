using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class NambahTimPemain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id_team",
                table: "MPemain",
                newName: "TimPemainId");

            migrationBuilder.AddColumn<long>(
                name: "TimPemainId_tim",
                table: "MPemain",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MTimPemain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PemainId_pemain = table.Column<int>(type: "int", nullable: true),
                    PemainId = table.Column<int>(type: "int", nullable: true),
                    TimId_tim = table.Column<long>(type: "bigint", nullable: true),
                    TimId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MTimPemain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MTimPemain_MPemain_PemainId_pemain",
                        column: x => x.PemainId_pemain,
                        principalTable: "MPemain",
                        principalColumn: "Id_pemain",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MTimPemain_MTim_TimId_tim",
                        column: x => x.TimId_tim,
                        principalTable: "MTim",
                        principalColumn: "Id_tim",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MPemain_TimPemainId_tim",
                table: "MPemain",
                column: "TimPemainId_tim");

            migrationBuilder.CreateIndex(
                name: "IX_MTimPemain_PemainId_pemain",
                table: "MTimPemain",
                column: "PemainId_pemain");

            migrationBuilder.CreateIndex(
                name: "IX_MTimPemain_TimId_tim",
                table: "MTimPemain",
                column: "TimId_tim");

            migrationBuilder.AddForeignKey(
                name: "FK_MPemain_MTim_TimPemainId_tim",
                table: "MPemain",
                column: "TimPemainId_tim",
                principalTable: "MTim",
                principalColumn: "Id_tim",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MPemain_MTim_TimPemainId_tim",
                table: "MPemain");

            migrationBuilder.DropTable(
                name: "MTimPemain");

            migrationBuilder.DropIndex(
                name: "IX_MPemain_TimPemainId_tim",
                table: "MPemain");

            migrationBuilder.DropColumn(
                name: "TimPemainId_tim",
                table: "MPemain");

            migrationBuilder.RenameColumn(
                name: "TimPemainId",
                table: "MPemain",
                newName: "Id_team");
        }
    }
}
