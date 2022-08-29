using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eProdaja.Services.Migrations
{
    public partial class addedtable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favoriti_Proizvodi_ProizvodId",
                table: "Favoriti");

            migrationBuilder.DropIndex(
                name: "IX_Favoriti_ProizvodId",
                table: "Favoriti");

            migrationBuilder.AddColumn<int>(
                name: "ProizvodId1",
                table: "Favoriti",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2022, 8, 21, 19, 46, 52, 78, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 2,
                column: "DatumRegistracije",
                value: new DateTime(2022, 8, 21, 19, 46, 52, 78, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 3,
                column: "DatumRegistracije",
                value: new DateTime(2022, 8, 21, 19, 46, 52, 78, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 19, 46, 52, 78, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 19, 46, 52, 78, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 19, 46, 52, 78, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 4,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 19, 46, 52, 78, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.CreateIndex(
                name: "IX_Favoriti_ProizvodId1",
                table: "Favoriti",
                column: "ProizvodId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Favoriti_Proizvodi_ProizvodId1",
                table: "Favoriti",
                column: "ProizvodId1",
                principalTable: "Proizvodi",
                principalColumn: "ProizvodID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favoriti_Proizvodi_ProizvodId1",
                table: "Favoriti");

            migrationBuilder.DropIndex(
                name: "IX_Favoriti_ProizvodId1",
                table: "Favoriti");

            migrationBuilder.DropColumn(
                name: "ProizvodId1",
                table: "Favoriti");

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2022, 8, 21, 14, 22, 1, 605, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 2,
                column: "DatumRegistracije",
                value: new DateTime(2022, 8, 21, 14, 22, 1, 605, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Kupci",
                keyColumn: "KupacID",
                keyValue: 3,
                column: "DatumRegistracije",
                value: new DateTime(2022, 8, 21, 14, 22, 1, 605, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 22, 1, 605, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 22, 1, 605, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 22, 1, 605, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 4,
                column: "Datum",
                value: new DateTime(2022, 8, 21, 14, 22, 1, 605, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.CreateIndex(
                name: "IX_Favoriti_ProizvodId",
                table: "Favoriti",
                column: "ProizvodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favoriti_Proizvodi_ProizvodId",
                table: "Favoriti",
                column: "ProizvodId",
                principalTable: "Proizvodi",
                principalColumn: "ProizvodID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
