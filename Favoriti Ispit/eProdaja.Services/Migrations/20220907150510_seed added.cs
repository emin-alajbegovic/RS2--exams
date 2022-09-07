using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eProdaja.Services.Migrations
{
    public partial class seedadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Favoriti",
                columns: new[] { "FavoritiId", "Datum", "KorisnikId", "ProizvodId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 7, 17, 5, 10, 152, DateTimeKind.Local).AddTicks(8837), 1, 1 },
                    { 2, new DateTime(2022, 9, 7, 17, 5, 10, 152, DateTimeKind.Local).AddTicks(8849), 2, 2 },
                    { 3, new DateTime(2022, 9, 7, 17, 5, 10, 152, DateTimeKind.Local).AddTicks(8859), 1, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2022, 9, 7, 17, 5, 10, 152, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 2,
                column: "DatumRegistracije",
                value: new DateTime(2022, 9, 7, 17, 5, 10, 152, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 3,
                column: "DatumRegistracije",
                value: new DateTime(2022, 9, 7, 17, 5, 10, 152, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 9, 7, 17, 5, 10, 152, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 9, 7, 17, 5, 10, 152, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 9, 7, 17, 5, 10, 152, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 4,
                column: "Datum",
                value: new DateTime(2022, 9, 7, 17, 5, 10, 152, DateTimeKind.Local).AddTicks(8750));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Favoriti",
                keyColumn: "FavoritiId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Favoriti",
                keyColumn: "FavoritiId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Favoriti",
                keyColumn: "FavoritiId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2022, 9, 7, 16, 59, 55, 429, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 2,
                column: "DatumRegistracije",
                value: new DateTime(2022, 9, 7, 16, 59, 55, 429, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 3,
                column: "DatumRegistracije",
                value: new DateTime(2022, 9, 7, 16, 59, 55, 429, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 9, 7, 16, 59, 55, 429, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 9, 7, 16, 59, 55, 429, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 9, 7, 16, 59, 55, 429, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 4,
                column: "Datum",
                value: new DateTime(2022, 9, 7, 16, 59, 55, 429, DateTimeKind.Local).AddTicks(5496));
        }
    }
}
