using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YardimMasasi.VeriErisim.Migrations
{
    public partial class duyuruAlanlar1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Baslik",
                table: "Duyurular",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 6,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 7,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 8,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 9,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 10,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 11,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 12,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 13,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 14,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 15,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 16,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 17,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 18,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 6,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 6,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 7,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 8,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 13, 35, 37, 747, DateTimeKind.Local).AddTicks(7191));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Baslik",
                table: "Duyurular");

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 6,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 7,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 8,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 9,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 10,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 11,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 12,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 13,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 14,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 15,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 16,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 17,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "AltKonular",
                keyColumn: "Id",
                keyValue: 18,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "AnaKonular",
                keyColumn: "Id",
                keyValue: 6,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 6,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 7,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Ekipler",
                keyColumn: "Id",
                keyValue: 8,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 5, 7, 0, 37, 37, 827, DateTimeKind.Local).AddTicks(5842));
        }
    }
}
