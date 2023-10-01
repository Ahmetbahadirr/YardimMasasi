using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YardimMasasi.VeriErisim.Migrations
{
    public partial class pluralizing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AltKonu_AnaKonu_AnaKonuId",
                table: "AltKonu");

            migrationBuilder.DropForeignKey(
                name: "FK_GorevIslem_Gorev_GorevId",
                table: "GorevIslem");

            migrationBuilder.DropForeignKey(
                name: "FK_GorevMesaj_Gorev_GorevId",
                table: "GorevMesaj");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gorev",
                table: "Gorev");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnaKonu",
                table: "AnaKonu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AltKonu",
                table: "AltKonu");

            migrationBuilder.RenameTable(
                name: "Gorev",
                newName: "Gorevler");

            migrationBuilder.RenameTable(
                name: "AnaKonu",
                newName: "AnaKonular");

            migrationBuilder.RenameTable(
                name: "AltKonu",
                newName: "AltKonular");

            migrationBuilder.RenameIndex(
                name: "IX_AltKonu_AnaKonuId",
                table: "AltKonular",
                newName: "IX_AltKonular_AnaKonuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gorevler",
                table: "Gorevler",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnaKonular",
                table: "AnaKonular",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AltKonular",
                table: "AltKonular",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AltKonular_AnaKonular_AnaKonuId",
                table: "AltKonular",
                column: "AnaKonuId",
                principalTable: "AnaKonular",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GorevIslem_Gorevler_GorevId",
                table: "GorevIslem",
                column: "GorevId",
                principalTable: "Gorevler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GorevMesaj_Gorevler_GorevId",
                table: "GorevMesaj",
                column: "GorevId",
                principalTable: "Gorevler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AltKonular_AnaKonular_AnaKonuId",
                table: "AltKonular");

            migrationBuilder.DropForeignKey(
                name: "FK_GorevIslem_Gorevler_GorevId",
                table: "GorevIslem");

            migrationBuilder.DropForeignKey(
                name: "FK_GorevMesaj_Gorevler_GorevId",
                table: "GorevMesaj");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gorevler",
                table: "Gorevler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnaKonular",
                table: "AnaKonular");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AltKonular",
                table: "AltKonular");

            migrationBuilder.RenameTable(
                name: "Gorevler",
                newName: "Gorev");

            migrationBuilder.RenameTable(
                name: "AnaKonular",
                newName: "AnaKonu");

            migrationBuilder.RenameTable(
                name: "AltKonular",
                newName: "AltKonu");

            migrationBuilder.RenameIndex(
                name: "IX_AltKonular_AnaKonuId",
                table: "AltKonu",
                newName: "IX_AltKonu_AnaKonuId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gorev",
                table: "Gorev",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnaKonu",
                table: "AnaKonu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AltKonu",
                table: "AltKonu",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AltKonu_AnaKonu_AnaKonuId",
                table: "AltKonu",
                column: "AnaKonuId",
                principalTable: "AnaKonu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GorevIslem_Gorev_GorevId",
                table: "GorevIslem",
                column: "GorevId",
                principalTable: "Gorev",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GorevMesaj_Gorev_GorevId",
                table: "GorevMesaj",
                column: "GorevId",
                principalTable: "Gorev",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
