using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 3, 19, 18, 22, 20, 138, DateTimeKind.Local).AddTicks(5652), "https://cdn.pixabay.com/photo/2016/03/28/09/34/bedroom-1285156__340.jpg", 2, 150.0, 800 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate", "ImageUrl", "Name", "Rate", "Sqft" },
                values: new object[] { "Free Beer", new DateTime(2023, 3, 19, 18, 22, 20, 138, DateTimeKind.Local).AddTicks(5709), "https://cdn.pixabay.com/photo/2017/04/28/22/16/room-2269594__340.jpg", "Premium Pool Villa", 250.0, 1000 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "Free Snacks", new DateTime(2023, 3, 19, 18, 22, 20, 138, DateTimeKind.Local).AddTicks(5712), "https://cdn.pixabay.com/photo/2020/10/18/09/16/bedroom-5664221__340.jpg", "Luxury Pool Villa", 2, 150.0, 650 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate", "ImageUrl", "Name", "Rate", "Sqft" },
                values: new object[] { "Free Massage", new DateTime(2023, 3, 19, 18, 22, 20, 138, DateTimeKind.Local).AddTicks(5714), "https://cdn.pixabay.com/photo/2016/04/15/11/46/bedroom-1330846__340.jpg", "Diamond Villa", 350.0, 900 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 3, 19, 18, 22, 20, 138, DateTimeKind.Local).AddTicks(5716), "https://cdn.pixabay.com/photo/2019/08/19/13/58/bed-4416515__340.jpg", "Diamond Pool Villa", 2, 250.0, 800 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 3, 19, 15, 12, 14, 216, DateTimeKind.Local).AddTicks(7825), "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg", 4, 50.0, 550 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amenity", "CreatedDate", "ImageUrl", "Name", "Rate", "Sqft" },
                values: new object[] { "Free Drinks", new DateTime(2023, 3, 19, 15, 12, 14, 216, DateTimeKind.Local).AddTicks(7877), "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg", "Royal Villa", 50.0, 550 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amenity", "CreatedDate", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { "Free Drinks", new DateTime(2023, 3, 19, 15, 12, 14, 216, DateTimeKind.Local).AddTicks(7880), "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg", "Royal Villa", 4, 50.0, 550 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amenity", "CreatedDate", "ImageUrl", "Name", "Rate", "Sqft" },
                values: new object[] { "Free Drinks", new DateTime(2023, 3, 19, 15, 12, 14, 216, DateTimeKind.Local).AddTicks(7882), "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg", "Royal Villa", 50.0, 550 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft" },
                values: new object[] { new DateTime(2023, 3, 19, 15, 12, 14, 216, DateTimeKind.Local).AddTicks(7884), "https://cdn.pixabay.com/photo/2022/12/04/16/17/leaves-7634894_640.jpg", "Royal Villa", 4, 50.0, 550 });
        }
    }
}
