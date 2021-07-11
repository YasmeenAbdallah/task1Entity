using Microsoft.EntityFrameworkCore.Migrations;

namespace task1Entity.Migrations
{
    public partial class makeIDPrimart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "products",
                newName: "ProductsId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Clients",
                newName: "ClientsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "products",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ClientsId",
                table: "Clients",
                newName: "id");
        }
    }
}
