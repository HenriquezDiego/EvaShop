using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaShop.Data.Migrations
{
    public partial class AddCategoriaHombre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "Imagen", "Nombre" },
                values: new object[] { 5, "/images/hombre.jpg", "Hombre" });

            migrationBuilder.InsertData(
                table: "SubCategoria",
                columns: new[] { "Id", "CategoriaId", "Nombre" },
                values: new object[] { 13, 5, "Boxer" });

            migrationBuilder.InsertData(
                table: "SubCategoria",
                columns: new[] { "Id", "CategoriaId", "Nombre" },
                values: new object[] { 14, 5, "Calcetines" });

            migrationBuilder.InsertData(
                table: "SubCategoria",
                columns: new[] { "Id", "CategoriaId", "Nombre" },
                values: new object[] { 15, 5, "Bañadores" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubCategoria",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SubCategoria",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SubCategoria",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
