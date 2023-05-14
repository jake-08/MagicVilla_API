using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "magicvilla",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 13, 22, 9, 33, 778, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                schema: "magicvilla",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 13, 22, 9, 33, 778, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                schema: "magicvilla",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 13, 22, 9, 33, 778, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                schema: "magicvilla",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 13, 22, 9, 33, 778, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                schema: "magicvilla",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 13, 22, 9, 33, 778, DateTimeKind.Local).AddTicks(5354));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "magicvilla",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 13, 22, 5, 26, 430, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                schema: "magicvilla",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 13, 22, 5, 26, 430, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                schema: "magicvilla",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 13, 22, 5, 26, 430, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                schema: "magicvilla",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 13, 22, 5, 26, 430, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                schema: "magicvilla",
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 13, 22, 5, 26, 430, DateTimeKind.Local).AddTicks(2522));
        }
    }
}
