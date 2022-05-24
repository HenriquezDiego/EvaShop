using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaShop.Data.Migrations
{
    public partial class ModDetalleV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalles_Articulos_ArticuloId",
                table: "Detalles");

            migrationBuilder.DropIndex(
                name: "IX_Detalles_ArticuloId",
                table: "Detalles");

            migrationBuilder.DropColumn(
                name: "ArticuloId",
                table: "Detalles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ArticuloId",
                table: "Detalles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_ArticuloId",
                table: "Detalles",
                column: "ArticuloId");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalles_Articulos_ArticuloId",
                table: "Detalles",
                column: "ArticuloId",
                principalTable: "Articulos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
