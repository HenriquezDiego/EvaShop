using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaShop.Data.Migrations
{
    public partial class DataSeederArticulosV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("15f3f10e-bf0a-4928-da17-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/top_celeste.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("39cd5613-5683-4cea-da18-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/top_negro.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("53747151-4819-4adc-da14-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/top_doble_faz.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("6836d141-693c-49ab-da15-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/deportivo_crop_top.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("a9a00ad2-f3e3-4bac-da16-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/top_deportivo.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("15f3f10e-bf0a-4928-da17-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/top celeste.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("39cd5613-5683-4cea-da18-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/top negro.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("53747151-4819-4adc-da14-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/top doble faz.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("6836d141-693c-49ab-da15-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/deportivo crop top.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("a9a00ad2-f3e3-4bac-da16-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/top deportivo.jpg");
        }
    }
}
