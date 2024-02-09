using Microsoft.EntityFrameworkCore.Migrations;

namespace ROCVESTAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShortDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Image", "Price", "Quantity", "ShortDesc", "Title" },
                values: new object[,]
                {
                    { 1, "Category 1", "image1.jpg", 10.99m, 100, "Short description for Product 1", "Product 1" },
                    { 2, "Category 2", "image2.jpg", 20.99m, 150, "Short description for Product 2", "Product 2" },
                    { 3, "Category 3", "image3.jpg", 30.99m, 350, "Short description for Product 3", "Product 3" },
                    { 4, "Category 4", "image4.jpg", 40.70m, 480, "Short description for Product 4", "Product 4" },
                    { 5, "Category 5", "image5.jpg", 20.99m, 550, "Short description for Product 5", "Product 5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
