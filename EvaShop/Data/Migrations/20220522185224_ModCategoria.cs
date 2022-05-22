using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaShop.Data.Migrations
{
    public partial class ModCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategoria_Categorias_CategoriaId",
                table: "SubCategoria");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "SubCategoria",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategoria_Categorias_CategoriaId",
                table: "SubCategoria",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategoria_Categorias_CategoriaId",
                table: "SubCategoria");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "SubCategoria",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategoria_Categorias_CategoriaId",
                table: "SubCategoria",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }
    }
}
