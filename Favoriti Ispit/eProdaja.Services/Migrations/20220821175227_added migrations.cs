using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eProdaja.Services.Migrations
{
    public partial class addedmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Favoriti",
                columns: new[] { "FavoritiId", "Datum", "KorisnikId", "ProizvodId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 21, 19, 52, 26, 601, DateTimeKind.Local).AddTicks(7119), 1, 1 },
                    { 2, new DateTime(2022, 8, 21, 19, 52, 26, 601, DateTimeKind.Local).AddTicks(7144), 2, 2 },
                    { 3, new DateTime(2022, 8, 21, 19, 52, 26, 601, DateTimeKind.Local).AddTicks(7160), 2, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2022, 8, 21, 19, 52, 26, 601, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 2,
                column: "DatumRegistracije",
                value: new DateTime(2022, 8, 21, 19, 52, 26, 601, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 3,
                column: "DatumRegistracije",
                value: new DateTime(2022, 8, 21, 19, 52, 26, 601, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 19, 52, 26, 601, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 19, 52, 26, 601, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 19, 52, 26, 601, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 4,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 19, 52, 26, 601, DateTimeKind.Local).AddTicks(7003));
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
                value: new DateTime(2022, 8, 21, 19, 51, 47, 582, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 2,
                column: "DatumRegistracije",
                value: new DateTime(2022, 8, 21, 19, 51, 47, 582, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 3,
                column: "DatumRegistracije",
                value: new DateTime(2022, 8, 21, 19, 51, 47, 582, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 19, 51, 47, 582, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 19, 51, 47, 582, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 19, 51, 47, 582, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 4,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 19, 51, 47, 582, DateTimeKind.Local).AddTicks(1541));
        }
    }
}
