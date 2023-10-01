using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YardimMasasi.VeriErisim.Migrations
{
    public partial class kullaniciRolMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menuler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HtmlClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menuler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    RolAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciRoller",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciRoller", x => new { x.KullaniciId, x.RolId });
                    table.ForeignKey(
                        name: "FK_KullaniciRoller_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciRoller_Roller_RolId",
                        column: x => x.RolId,
                        principalTable: "Roller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolMenuler",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolMenuler", x => new { x.RolId, x.MenuId });
                    table.ForeignKey(
                        name: "FK_RolMenuler_Menuler_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menuler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolMenuler_Roller_RolId",
                        column: x => x.RolId,
                        principalTable: "Roller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciRoller_RolId",
                table: "KullaniciRoller",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_RolMenuler_MenuId",
                table: "RolMenuler",
                column: "MenuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciRoller");

            migrationBuilder.DropTable(
                name: "RolMenuler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Menuler");

            migrationBuilder.DropTable(
                name: "Roller");

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
    }
}
