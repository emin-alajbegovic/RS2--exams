using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eProdaja.Services.Migrations
{
    public partial class newtableadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Favoriti",
                columns: table => new
                {
                    FavoritiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoriti", x => x.FavoritiId);
                    table.ForeignKey(
                        name: "FK_Favoriti_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favoriti_Proizvodi_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2022, 9, 8, 8, 53, 1, 102, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 2,
                column: "DatumRegistracije",
                value: new DateTime(2022, 9, 8, 8, 53, 1, 102, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 3,
                column: "DatumRegistracije",
                value: new DateTime(2022, 9, 8, 8, 53, 1, 102, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 9, 8, 8, 53, 1, 102, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 9, 8, 8, 53, 1, 102, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 9, 8, 8, 53, 1, 102, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 4,
                column: "Datum",
                value: new DateTime(2022, 9, 8, 8, 53, 1, 102, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.CreateIndex(
                name: "IX_Favoriti_KorisnikId",
                table: "Favoriti",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Favoriti_ProizvodId",
                table: "Favoriti",
                column: "ProizvodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favoriti");

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2022, 7, 18, 23, 37, 23, 17, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 2,
                column: "DatumRegistracije",
                value: new DateTime(2022, 7, 18, 23, 37, 23, 17, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 3,
                column: "DatumRegistracije",
                value: new DateTime(2022, 7, 18, 23, 37, 23, 17, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 7, 18, 23, 37, 23, 17, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 7, 18, 23, 37, 23, 17, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 7, 18, 23, 37, 23, 17, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 4,
                column: "Datum",
                value: new DateTime(2022, 7, 18, 23, 37, 23, 17, DateTimeKind.Local).AddTicks(2458));
        }
    }
}
