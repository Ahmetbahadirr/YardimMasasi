using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YardimMasasi.VeriErisim.Migrations
{
    public partial class seedVeAdAlanlari : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AltKonular_SurecTanimlari_SurecTanimiId",
                table: "AltKonular");

            migrationBuilder.AddColumn<string>(
                name: "Baslik",
                table: "Gorevler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Icerik",
                table: "Gorevler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Adi",
                table: "Ekipler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Adi",
                table: "Birimler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tanim",
                table: "AnaKonular",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "SurecTanimiId",
                table: "AltKonular",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Tanim",
                table: "AltKonular",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AnaKonular",
                columns: new[] { "Id", "OlusturmaTarihi", "Silindi", "Tanim" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5647), false, "Donanım Sorunları" },
                    { 2, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5651), false, "Sistem Sorunları" },
                    { 3, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5652), false, "Erişim Sorunları" },
                    { 4, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5654), false, "Tanımlama Sorunları" },
                    { 5, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5655), false, "E-posta Sorunları" },
                    { 6, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5658), false, "Şifre Sorunları" }
                });

            migrationBuilder.InsertData(
                table: "Birimler",
                columns: new[] { "Id", "Adi", "OlusturmaTarihi", "Silindi" },
                values: new object[,]
                {
                    { 1, "Yazılım ve Uygulama Müdürlüğü", new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5811), false },
                    { 2, "Donanım Müdürlüğü", new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5814), false },
                    { 3, "Network Müdürlüğü", new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5815), false },
                    { 4, "Sistem Müdürlüğü", new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5817), false }
                });

            migrationBuilder.InsertData(
                table: "AltKonular",
                columns: new[] { "Id", "AnaKonuId", "OlusturmaTarihi", "Silindi", "SurecTanimiId", "Tanim" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5754), false, null, "Ekran Çalışmıyor" },
                    { 2, 1, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5757), false, null, "Bilgisayarım Açılmıyor" },
                    { 3, 1, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5758), false, null, "Klavye/Mouse Çalışmıyor" },
                    { 4, 2, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5761), false, null, "Sistem Genel Sorun" },
                    { 5, 2, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5763), false, null, "Ebys Açılmıyor" },
                    { 6, 2, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5765), false, null, "E-İmza çalışmıyor" },
                    { 7, 3, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5767), false, null, "Ebys sistemi erişemiyorum" },
                    { 8, 3, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5768), false, null, "Ortak klasöre erişemiyorum" },
                    { 9, 3, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5770), false, null, "Ağ bağlantı hatası" },
                    { 10, 4, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5772), false, null, "Profil tanımlama" },
                    { 11, 4, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5773), false, null, "Ebys tanımlama" },
                    { 12, 4, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5775), false, null, "Kullanıcı tanımlama" },
                    { 13, 5, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5777), false, null, "E-posta açılmıyor" },
                    { 14, 5, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5779), false, null, "Kota artırımı" },
                    { 15, 5, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5781), false, null, "Arşivleme Sorunu" },
                    { 16, 6, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5783), false, null, "Portal şifre sorunu" },
                    { 17, 6, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5785), false, null, "Şifre güncelleme sorunu" },
                    { 18, 6, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5787), false, null, "Domain şifresi sorunu" }
                });

            migrationBuilder.InsertData(
                table: "Ekipler",
                columns: new[] { "Id", "Adi", "BirimId", "OlusturmaTarihi", "Silindi" },
                values: new object[,]
                {
                    { 1, "Ebys/E-imza Ekibi", 1, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5831), false },
                    { 2, "Portal Ekibi", 1, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5833), false },
                    { 3, "Bilgisayar Donanımları Ekibi", 2, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5834), false },
                    { 4, "Network Donanımları Ekibi", 2, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5836), false },
                    { 5, "Network Güvenlik Ekibi", 3, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5837), false },
                    { 6, "Network Erişim Ekibi", 3, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5839), false },
                    { 7, "Sunucu Ekibi", 4, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5841), false },
                    { 8, "Veri Tabanı Ekibi", 4, new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5842), false }
                });

            migrationBuilder.InsertData(
                table: "EkipAltKonular",
                columns: new[] { "AltKonuId", "EkipId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 11, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AltKonular_SurecTanimlari_SurecTanimiId",
                table: "AltKonular",
                column: "SurecTanimiId",
                principalTable: "SurecTanimlari",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AltKonular_SurecTanimlari_SurecTanimiId",
                table: "AltKonular");

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "EkipAltKonular",
                keyColumns: new[] { "AltKonuId", "EkipId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "EkipAltKonular",
                keyColumns: new[] { "AltKonuId", "EkipId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "EkipAltKonular",
                keyColumns: new[] { "AltKonuId", "EkipId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "EkipAltKonular",
                keyColumns: new[] { "AltKonuId", "EkipId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "EkipAltKonular",
                keyColumns: new[] { "AltKonuId", "EkipId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "EkipAltKonular",
                keyColumns: new[] { "AltKonuId", "EkipId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "EkipAltKonular",
                keyColumns: new[] { "AltKonuId", "EkipId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Baslik",
                table: "Gorevler");

            migrationBuilder.DropColumn(
                name: "Icerik",
                table: "Gorevler");

            migrationBuilder.DropColumn(
                name: "Adi",
                table: "Ekipler");

            migrationBuilder.DropColumn(
                name: "Adi",
                table: "Birimler");

            migrationBuilder.DropColumn(
                name: "Tanim",
                table: "AnaKonular");

            migrationBuilder.DropColumn(
                name: "Tanim",
                table: "AltKonular");

            migrationBuilder.AlterColumn<int>(
                name: "SurecTanimiId",
                table: "AltKonular",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AltKonular_SurecTanimlari_SurecTanimiId",
                table: "AltKonular",
                column: "SurecTanimiId",
                principalTable: "SurecTanimlari",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
