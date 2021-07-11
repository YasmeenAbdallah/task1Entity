using Microsoft.EntityFrameworkCore.Migrations;

namespace task1Entity.Migrations
{
    public partial class updateRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientProduct_Clients_ClientsClientId",
                table: "ClientProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientProduct_Products_ProductsProductId",
                table: "ClientProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientProduct",
                table: "ClientProduct");

            migrationBuilder.DropIndex(
                name: "IX_ClientProduct_ProductsProductId",
                table: "ClientProduct");

            migrationBuilder.RenameColumn(
                name: "ProductsProductId",
                table: "ClientProduct",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "ClientsClientId",
                table: "ClientProduct",
                newName: "ProductId");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "ClientProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientProduct",
                table: "ClientProduct",
                columns: new[] { "ClientId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_ClientProduct_ProductId",
                table: "ClientProduct",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientProduct_Clients_ClientId",
                table: "ClientProduct",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientProduct_Products_ProductId",
                table: "ClientProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientProduct_Clients_ClientId",
                table: "ClientProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientProduct_Products_ProductId",
                table: "ClientProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientProduct",
                table: "ClientProduct");

            migrationBuilder.DropIndex(
                name: "IX_ClientProduct_ProductId",
                table: "ClientProduct");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "ClientProduct");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "ClientProduct",
                newName: "ProductsProductId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ClientProduct",
                newName: "ClientsClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientProduct",
                table: "ClientProduct",
                columns: new[] { "ClientsClientId", "ProductsProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_ClientProduct_ProductsProductId",
                table: "ClientProduct",
                column: "ProductsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientProduct_Clients_ClientsClientId",
                table: "ClientProduct",
                column: "ClientsClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientProduct_Products_ProductsProductId",
                table: "ClientProduct",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
