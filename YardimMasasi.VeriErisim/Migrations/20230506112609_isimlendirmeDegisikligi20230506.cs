using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YardimMasasi.VeriErisim.Migrations
{
    public partial class isimlendirmeDegisikligi20230506 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ekip_Birim_BirimId",
                table: "Ekip");

            migrationBuilder.DropForeignKey(
                name: "FK_EkipAltKonular_Ekip_EkipId",
                table: "EkipAltKonular");

            migrationBuilder.DropForeignKey(
                name: "FK_SurecAdimi_Birim_BirimId",
                table: "SurecAdimi");

            migrationBuilder.DropForeignKey(
                name: "FK_SurecAdimiTanimi_Birim_BirimId",
                table: "SurecAdimiTanimi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ekip",
                table: "Ekip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Birim",
                table: "Birim");

            migrationBuilder.RenameTable(
                name: "Ekip",
                newName: "Ekipler");

            migrationBuilder.RenameTable(
                name: "Birim",
                newName: "Birimler");

            migrationBuilder.RenameIndex(
                name: "IX_Ekip_BirimId",
                table: "Ekipler",
                newName: "IX_Ekipler_BirimId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ekipler",
                table: "Ekipler",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Birimler",
                table: "Birimler",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EkipAltKonular_Ekipler_EkipId",
                table: "EkipAltKonular",
                column: "EkipId",
                principalTable: "Ekipler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ekipler_Birimler_BirimId",
                table: "Ekipler",
                column: "BirimId",
                principalTable: "Birimler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SurecAdimi_Birimler_BirimId",
                table: "SurecAdimi",
                column: "BirimId",
                principalTable: "Birimler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SurecAdimiTanimi_Birimler_BirimId",
                table: "SurecAdimiTanimi",
                column: "BirimId",
                principalTable: "Birimler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EkipAltKonular_Ekipler_EkipId",
                table: "EkipAltKonular");

            migrationBuilder.DropForeignKey(
                name: "FK_Ekipler_Birimler_BirimId",
                table: "Ekipler");

            migrationBuilder.DropForeignKey(
                name: "FK_SurecAdimi_Birimler_BirimId",
                table: "SurecAdimi");

            migrationBuilder.DropForeignKey(
                name: "FK_SurecAdimiTanimi_Birimler_BirimId",
                table: "SurecAdimiTanimi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ekipler",
                table: "Ekipler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Birimler",
                table: "Birimler");

            migrationBuilder.RenameTable(
                name: "Ekipler",
                newName: "Ekip");

            migrationBuilder.RenameTable(
                name: "Birimler",
                newName: "Birim");

            migrationBuilder.RenameIndex(
                name: "IX_Ekipler_BirimId",
                table: "Ekip",
                newName: "IX_Ekip_BirimId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ekip",
                table: "Ekip",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Birim",
                table: "Birim",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ekip_Birim_BirimId",
                table: "Ekip",
                column: "BirimId",
                principalTable: "Birim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EkipAltKonular_Ekip_EkipId",
                table: "EkipAltKonular",
                column: "EkipId",
                principalTable: "Ekip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SurecAdimi_Birim_BirimId",
                table: "SurecAdimi",
                column: "BirimId",
                principalTable: "Birim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SurecAdimiTanimi_Birim_BirimId",
                table: "SurecAdimiTanimi",
                column: "BirimId",
                principalTable: "Birim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
