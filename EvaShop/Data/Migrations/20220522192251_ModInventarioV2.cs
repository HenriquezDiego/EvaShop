using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaShop.Data.Migrations
{
    public partial class ModInventarioV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ArticuloId",
                table: "Inventarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_ArticuloId",
                table: "Inventarios",
                column: "ArticuloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventarios_Articulos_ArticuloId",
                table: "Inventarios",
                column: "ArticuloId",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventarios_Articulos_ArticuloId",
                table: "Inventarios");

            migrationBuilder.DropIndex(
                name: "IX_Inventarios_ArticuloId",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "ArticuloId",
                table: "Inventarios");
        }
    }
}
