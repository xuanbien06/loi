using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lesson3_CNLTWeb.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RoomTypes_BIT240041",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Phòng Trọ Sinh Viên" },
                    { 2, "Chung Cư Mini" },
                    { 3, "Phòng Studio Cao Cấp" }
                });

            migrationBuilder.InsertData(
                table: "Rooms_BIT240041",
                columns: new[] { "Id", "Area", "IsAvailable", "Name", "Price", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, 20.5, true, "Phòng 101", 1500000m, 1 },
                    { 2, 25.0, false, "Phòng 102", 1800000m, 1 },
                    { 3, 35.0, true, "Phòng 201", 3500000m, 2 },
                    { 4, 40.0, true, "Phòng 202", 3800000m, 2 },
                    { 5, 55.5, true, "Phòng VIP 1", 5500000m, 3 }
                });

            migrationBuilder.InsertData(
                table: "RoomImages_BIT240041",
                columns: new[] { "Id", "ImageUrl", "IsThumbnail", "RoomId" },
                values: new object[,]
                {
                    { 1, "https://dummyimage.com/600x400/000/fff&text=Room101-1", true, 1 },
                    { 2, "https://dummyimage.com/600x400/000/fff&text=Room101-2", false, 1 },
                    { 3, "https://dummyimage.com/600x400/000/fff&text=Room102-1", true, 2 },
                    { 4, "https://dummyimage.com/600x400/000/fff&text=Room102-2", false, 2 },
                    { 5, "https://dummyimage.com/600x400/000/fff&text=Room201-1", true, 3 },
                    { 6, "https://dummyimage.com/600x400/000/fff&text=Room201-2", false, 3 },
                    { 7, "https://dummyimage.com/600x400/000/fff&text=Room202-1", true, 4 },
                    { 8, "https://dummyimage.com/600x400/000/fff&text=Room202-2", false, 4 },
                    { 9, "https://dummyimage.com/600x400/000/fff&text=VIP1-1", true, 5 },
                    { 10, "https://dummyimage.com/600x400/000/fff&text=VIP1-2", false, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomImages_BIT240041",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomImages_BIT240041",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomImages_BIT240041",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomImages_BIT240041",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RoomImages_BIT240041",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RoomImages_BIT240041",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RoomImages_BIT240041",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RoomImages_BIT240041",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RoomImages_BIT240041",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RoomImages_BIT240041",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms_BIT240041",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms_BIT240041",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms_BIT240041",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms_BIT240041",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms_BIT240041",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RoomTypes_BIT240041",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomTypes_BIT240041",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomTypes_BIT240041",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
