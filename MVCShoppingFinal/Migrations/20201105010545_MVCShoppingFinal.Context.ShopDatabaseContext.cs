using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCShoppingFinal.Migrations
{
    public partial class MVCShoppingFinalContextShopDatabaseContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "infoNegocio",
                columns: table => new
                {
                    idNegocio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_infoNegocio", x => x.idNegocio);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "infoNegocio");
        }
    }
}
