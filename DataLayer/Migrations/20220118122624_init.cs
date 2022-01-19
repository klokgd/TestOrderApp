using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityOfSender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdressOfSender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityOfRecepient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdressOfRecepient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoodsWeight = table.Column<double>(type: "float", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
