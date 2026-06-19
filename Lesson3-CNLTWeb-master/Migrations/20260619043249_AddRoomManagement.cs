using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson3_CNLTWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddRoomManagement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes_BIT240041",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes_BIT240041", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms_BIT240041",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Area = table.Column<double>(type: "float", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms_BIT240041", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_BIT240041_RoomTypes_BIT240041_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomTypes_BIT240041",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomImages_BIT240041",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsThumbnail = table.Column<bool>(type: "bit", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomImages_BIT240041", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomImages_BIT240041_Rooms_BIT240041_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms_BIT240041",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomImages_BIT240041_RoomId",
                table: "RoomImages_BIT240041",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BIT240041_RoomTypeId",
                table: "Rooms_BIT240041",
                column: "RoomTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "RoomImages_BIT240041");

            migrationBuilder.DropTable(
                name: "Rooms_BIT240041");

            migrationBuilder.DropTable(
                name: "RoomTypes_BIT240041");
        }
    }
}
