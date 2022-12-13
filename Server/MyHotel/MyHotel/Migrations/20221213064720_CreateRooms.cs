using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyHotel.Migrations
{
    public partial class CreateRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FloorNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomType = table.Column<int>(type: "int", nullable: false),
                    BedType = table.Column<int>(type: "int", nullable: false),
                    RoomCount = table.Column<int>(type: "int", nullable: false),
                    RoomRate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
