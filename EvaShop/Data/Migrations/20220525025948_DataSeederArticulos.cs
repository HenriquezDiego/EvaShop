using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaShop.Data.Migrations
{
    public partial class DataSeederArticulos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("3076acf5-dec1-4066-da1b-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/encaje_tres.jpg");

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
                keyValue: new Guid("5e60f0e9-7aad-4428-da1a-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/encaje_dos.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("6836d141-693c-49ab-da15-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/deportivo crop top.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("85913343-0ffa-453d-da1c-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/encaje_cuatro.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("86874437-431d-4745-da1d-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/encaje_cinco.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("a9a00ad2-f3e3-4bac-da16-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/top deportivo.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("f8ccb148-e1c5-4e99-da19-08da3c25f9c1"),
                column: "Imagenes",
                value: "/images/articulos/encaje_uno.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("15f3f10e-bf0a-4928-da17-08da3c25f9c1"),
                column: "Imagenes",
                value: "/imagenes/articulos/top celeste.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("3076acf5-dec1-4066-da1b-08da3c25f9c1"),
                column: "Imagenes",
                value: "/imagenes/articulos/encaje_tres.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("39cd5613-5683-4cea-da18-08da3c25f9c1"),
                column: "Imagenes",
                value: "/imagenes/articulos/top negro.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("53747151-4819-4adc-da14-08da3c25f9c1"),
                column: "Imagenes",
                value: "/imagenes/articulos/top doble faz.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("5e60f0e9-7aad-4428-da1a-08da3c25f9c1"),
                column: "Imagenes",
                value: "/imagenes/articulos/encaje_dos.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("6836d141-693c-49ab-da15-08da3c25f9c1"),
                column: "Imagenes",
                value: "/imagenes/articulos/deportivo crop top.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("85913343-0ffa-453d-da1c-08da3c25f9c1"),
                column: "Imagenes",
                value: "/imagenes/articulos/encaje_cuatro.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("86874437-431d-4745-da1d-08da3c25f9c1"),
                column: "Imagenes",
                value: "/imagenes/articulos/encaje_cinco.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("a9a00ad2-f3e3-4bac-da16-08da3c25f9c1"),
                column: "Imagenes",
                value: "/imagenes/articulos/top deportivo.jpg");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("f8ccb148-e1c5-4e99-da19-08da3c25f9c1"),
                column: "Imagenes",
                value: "/imagenes/articulos/encaje_uno.jpg");
        }
    }
}
