using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class PenambahanUntukMapingPosisiPemain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MPosisiPemain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PemainId = table.Column<int>(type: "int", nullable: true),
                    PosisiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MPosisiPemain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MPosisiPemain_MPemain_PemainId",
                        column: x => x.PemainId,
                        principalTable: "MPemain",
                        principalColumn: "Id_pemain",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MPosisiPemain_MPosisi_PosisiId",
                        column: x => x.PosisiId,
                        principalTable: "MPosisi",
                        principalColumn: "id_posisi",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MPosisiPemain_PemainId",
                table: "MPosisiPemain",
                column: "PemainId");

            migrationBuilder.CreateIndex(
                name: "IX_MPosisiPemain_PosisiId",
                table: "MPosisiPemain",
                column: "PosisiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MPosisiPemain");
        }
    }
}
