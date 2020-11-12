using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCShoppingFinal.Migrations
{
    public partial class MVCShoppingFinalContextShopDatabaseContextTry2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    idProducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    precio = table.Column<float>(nullable: false),
                    talle = table.Column<int>(nullable: false),
                    NegocioidNegocio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.idProducto);
                    table.ForeignKey(
                        name: "FK_Producto_infoNegocio_NegocioidNegocio",
                        column: x => x.NegocioidNegocio,
                        principalTable: "infoNegocio",
                        principalColumn: "idNegocio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Producto_NegocioidNegocio",
                table: "Producto",
                column: "NegocioidNegocio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
