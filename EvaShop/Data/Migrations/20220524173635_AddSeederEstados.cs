using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaShop.Data.Migrations
{
    public partial class AddSeederEstados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 0, "EnProceso" },
                    { 1, "Facturado" },
                    { 2, "Enviado" },
                    { 3, "Recibido" },
                    { 4, "Cancelado" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: 0);

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
