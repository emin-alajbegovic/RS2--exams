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
                    { 1, new DateTime(2022, 9, 8, 8, 55, 38, 852, DateTimeKind.Local).AddTicks(8609), 1, 1 },
                    { 2, new DateTime(2022, 9, 8, 8, 55, 38, 852, DateTimeKind.Local).AddTicks(8624), 2, 2 },
                    { 3, new DateTime(2022, 9, 8, 8, 55, 38, 852, DateTimeKind.Local).AddTicks(8635), 1, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2022, 9, 8, 8, 55, 38, 852, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 2,
                column: "DatumRegistracije",
                value: new DateTime(2022, 9, 8, 8, 55, 38, 852, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 3,
                column: "DatumRegistracije",
                value: new DateTime(2022, 9, 8, 8, 55, 38, 852, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 9, 8, 8, 55, 38, 852, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 9, 8, 8, 55, 38, 852, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 9, 8, 8, 55, 38, 852, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 4,
                column: "Datum",
                value: new DateTime(2022, 9, 8, 8, 55, 38, 852, DateTimeKind.Local).AddTicks(8507));
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
        }
    }
}
