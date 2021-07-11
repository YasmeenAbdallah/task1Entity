using Microsoft.EntityFrameworkCore.Migrations;

namespace task1Entity.Migrations
{
    public partial class addRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "ClientsId",
                table: "Clients",
                newName: "ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateTable(
                name: "ClientProduct",
                columns: table => new
                {
                    ClientsClientId = table.Column<int>(type: "int", nullable: false),
                    ProductsProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientProduct", x => new { x.ClientsClientId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_ClientProduct_Clients_ClientsClientId",
                        column: x => x.ClientsClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientProduct_ProductsProductId",
                table: "ClientProduct",
                column: "ProductsProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "products");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "products",
                newName: "ProductsId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Clients",
                newName: "ClientsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "ProductsId");
        }
    }
}
