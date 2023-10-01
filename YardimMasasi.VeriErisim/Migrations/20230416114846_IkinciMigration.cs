using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YardimMasasi.VeriErisim.Migrations
{
    public partial class IkinciMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnaKonu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnaKonu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AltKonu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnaKonuId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AltKonu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AltKonu_AnaKonu_AnaKonuId",
                        column: x => x.AnaKonuId,
                        principalTable: "AnaKonu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AltKonu_AnaKonuId",
                table: "AltKonu",
                column: "AnaKonuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AltKonu");

            migrationBuilder.DropTable(
                name: "AnaKonu");
        }
    }
}
