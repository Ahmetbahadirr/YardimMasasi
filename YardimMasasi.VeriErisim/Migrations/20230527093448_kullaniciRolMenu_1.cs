using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YardimMasasi.VeriErisim.Migrations
{
    public partial class kullaniciRolMenu_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Roller");

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 6,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 7,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 8,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 9,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 10,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 11,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 12,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 13,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 14,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 15,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 16,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 17,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 18,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 6,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 6,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 7,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 8,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 34, 48, 95, DateTimeKind.Local).AddTicks(2303));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Roller",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 6,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 7,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 8,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 9,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 10,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 11,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 12,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 13,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 14,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 15,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 16,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 17,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 18,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 6,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 6,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 7,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 8,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 27, 12, 27, 11, 305, DateTimeKind.Local).AddTicks(5725));
        }
    }
}
