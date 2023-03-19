using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Free Drinks", new DateTime(2023, 3, 14, 21, 19, 36, 370, DateTimeKind.Local).AddTicks(4402), "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg", "Royal Villa", 4, 50.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Free Drinks", new DateTime(2023, 3, 14, 21, 19, 36, 370, DateTimeKind.Local).AddTicks(4453), "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg", "Royal Villa", 4, 50.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Free Drinks", new DateTime(2023, 3, 14, 21, 19, 36, 370, DateTimeKind.Local).AddTicks(4455), "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg", "Royal Villa", 4, 50.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Free Drinks", new DateTime(2023, 3, 14, 21, 19, 36, 370, DateTimeKind.Local).AddTicks(4457), "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg", "Royal Villa", 4, 50.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Free Drinks", new DateTime(2023, 3, 14, 21, 19, 36, 370, DateTimeKind.Local).AddTicks(4459), "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg", "Royal Villa", 4, 50.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
