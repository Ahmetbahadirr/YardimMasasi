using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YardimMasasi.VeriErisim.Migrations
{
    public partial class surec_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SurecTanimiId",
                table: "AltKonular",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SurecTanimlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurecTanimlari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurecAdimiTanimi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    SurecTanimiId = table.Column<int>(type: "int", nullable: false),
                    BirimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurecAdimiTanimi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurecAdimiTanimi_Birim_BirimId",
                        column: x => x.BirimId,
                        principalTable: "Birim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurecAdimiTanimi_SurecTanimlari_SurecTanimiId",
                        column: x => x.SurecTanimiId,
                        principalTable: "SurecTanimlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Surecler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    SurecTanimiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surecler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Surecler_Gorevler_Id",
                        column: x => x.Id,
                        principalTable: "Gorevler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Surecler_SurecTanimlari_SurecTanimiId",
                        column: x => x.SurecTanimiId,
                        principalTable: "SurecTanimlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurecAdimi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sira = table.Column<int>(type: "int", nullable: false),
                    SurecId = table.Column<int>(type: "int", nullable: false),
                    BirimId = table.Column<int>(type: "int", nullable: false),
                    AktifAdim = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurecAdimi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurecAdimi_Birim_BirimId",
                        column: x => x.BirimId,
                        principalTable: "Birim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurecAdimi_Surecler_SurecId",
                        column: x => x.SurecId,
                        principalTable: "Surecler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AltKonular_SurecTanimiId",
                table: "AltKonular",
                column: "SurecTanimiId");

            migrationBuilder.CreateIndex(
                name: "IX_SurecAdimi_BirimId",
                table: "SurecAdimi",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_SurecAdimi_SurecId",
                table: "SurecAdimi",
                column: "SurecId");

            migrationBuilder.CreateIndex(
                name: "IX_SurecAdimiTanimi_BirimId",
                table: "SurecAdimiTanimi",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_SurecAdimiTanimi_SurecTanimiId",
                table: "SurecAdimiTanimi",
                column: "SurecTanimiId");

            migrationBuilder.CreateIndex(
                name: "IX_Surecler_SurecTanimiId",
                table: "Surecler",
                column: "SurecTanimiId");

            migrationBuilder.AddForeignKey(
                name: "FK_AltKonular_SurecTanimlari_SurecTanimiId",
                table: "AltKonular",
                column: "SurecTanimiId",
                principalTable: "SurecTanimlari",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AltKonular_SurecTanimlari_SurecTanimiId",
                table: "AltKonular");

            migrationBuilder.DropTable(
                name: "SurecAdimi");

            migrationBuilder.DropTable(
                name: "SurecAdimiTanimi");

            migrationBuilder.DropTable(
                name: "Surecler");

            migrationBuilder.DropTable(
                name: "SurecTanimlari");

            migrationBuilder.DropIndex(
                name: "IX_AltKonular_SurecTanimiId",
                table: "AltKonular");

            migrationBuilder.DropColumn(
                name: "SurecTanimiId",
                table: "AltKonular");
        }
    }
}
