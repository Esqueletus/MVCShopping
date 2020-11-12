using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCShoppingFinal.Migrations
{
    public partial class MVCShoppingFinalContextShopDatabaseContextTryFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaProd",
                table: "Producto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColorProd",
                table: "Producto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentNegocioId",
                table: "Producto",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoriaProd",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ColorProd",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "CurrentNegocioId",
                table: "Producto");
        }
    }
}
