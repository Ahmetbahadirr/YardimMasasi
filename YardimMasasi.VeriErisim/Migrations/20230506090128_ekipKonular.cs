using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YardimMasasi.VeriErisim.Migrations
{
    public partial class ekipKonular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EkipAltKonular",
                columns: table => new
                {
                    EkipId = table.Column<int>(type: "int", nullable: false),
                    AltKonuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkipAltKonular", x => new { x.AltKonuId, x.EkipId });
                    table.ForeignKey(
                        name: "FK_EkipAltKonular_AltKonular_AltKonuId",
                        column: x => x.AltKonuId,
                        principalTable: "AltKonular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EkipAltKonular_Ekip_EkipId",
                        column: x => x.EkipId,
                        principalTable: "Ekip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EkipAltKonular_EkipId",
                table: "EkipAltKonular",
                column: "EkipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EkipAltKonular");
        }
    }
}
