using Microsoft.EntityFrameworkCore.Migrations;

namespace task1Entity.Migrations
{
    public partial class addClientProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameTable(
                name: "ClientProduct",
                newName: "ClientProducts");

            migrationBuilder.RenameIndex(
                name: "IX_ClientProduct_ProductId",
                table: "ClientProducts",
                newName: "IX_ClientProducts_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientProducts",
                table: "ClientProducts",
                columns: new[] { "ClientId", "ProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ClientProducts_Clients_ClientId",
                table: "ClientProducts",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientProducts_Products_ProductId",
                table: "ClientProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientProducts_Clients_ClientId",
                table: "ClientProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientProducts_Products_ProductId",
                table: "ClientProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientProducts",
                table: "ClientProducts");

            migrationBuilder.RenameTable(
                name: "ClientProducts",
                newName: "ClientProduct");

            migrationBuilder.RenameIndex(
                name: "IX_ClientProducts_ProductId",
                table: "ClientProduct",
                newName: "IX_ClientProduct_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientProduct",
                table: "ClientProduct",
                columns: new[] { "ClientId", "ProductId" });

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
    }
}
