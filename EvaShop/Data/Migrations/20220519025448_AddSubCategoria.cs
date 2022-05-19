using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaShop.Data.Migrations
{
    public partial class AddSubCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Categorias_CategoriaId",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Articulos",
                newName: "SubCategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulos_CategoriaId",
                table: "Articulos",
                newName: "IX_Articulos_SubCategoriaId");

            migrationBuilder.CreateTable(
                name: "SubCategoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategoria_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoria_CategoriaId",
                table: "SubCategoria",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_SubCategoria_SubCategoriaId",
                table: "Articulos",
                column: "SubCategoriaId",
                principalTable: "SubCategoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_SubCategoria_SubCategoriaId",
                table: "Articulos");

            migrationBuilder.DropTable(
                name: "SubCategoria");

            migrationBuilder.RenameColumn(
                name: "SubCategoriaId",
                table: "Articulos",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulos_SubCategoriaId",
                table: "Articulos",
                newName: "IX_Articulos_CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Categorias_CategoriaId",
                table: "Articulos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
