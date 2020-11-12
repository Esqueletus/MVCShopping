using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCShoppingFinal.Migrations
{
    public partial class MVCShoppingFinalContextShopDatabaseContextNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "infoProducto",
                columns: table => new
                {
                    idProducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    precio = table.Column<float>(nullable: false),
                    talle = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_infoProducto", x => x.idProducto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "infoProducto");
        }
    }
}
