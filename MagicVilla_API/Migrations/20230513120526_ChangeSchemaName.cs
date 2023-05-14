using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSchemaName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "magicvilla");

            migrationBuilder.RenameTable(
                name: "Villas",
                newName: "Villas",
                newSchema: "magicvilla");

            migrationBuilder.RenameTable(
                name: "VillaNumbers",
                newName: "VillaNumbers",
                newSchema: "magicvilla");

            migrationBuilder.RenameTable(
                name: "LocalUsers",
                newName: "LocalUsers",
                newSchema: "magicvilla");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "AspNetUserTokens",
                newSchema: "magicvilla");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "AspNetUsers",
                newSchema: "magicvilla");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "AspNetUserRoles",
                newSchema: "magicvilla");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "AspNetUserLogins",
                newSchema: "magicvilla");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "AspNetUserClaims",
                newSchema: "magicvilla");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "AspNetRoles",
                newSchema: "magicvilla");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "AspNetRoleClaims",
                newSchema: "magicvilla");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Villas",
                schema: "magicvilla",
                newName: "Villas");

            migrationBuilder.RenameTable(
                name: "VillaNumbers",
                schema: "magicvilla",
                newName: "VillaNumbers");

            migrationBuilder.RenameTable(
                name: "LocalUsers",
                schema: "magicvilla",
                newName: "LocalUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                schema: "magicvilla",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "magicvilla",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                schema: "magicvilla",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                schema: "magicvilla",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                schema: "magicvilla",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                schema: "magicvilla",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                schema: "magicvilla",
                newName: "AspNetRoleClaims");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 22, 26, 22, 384, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 22, 26, 22, 384, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 22, 26, 22, 384, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 22, 26, 22, 384, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 22, 26, 22, 384, DateTimeKind.Local).AddTicks(5756));
        }
    }
}
