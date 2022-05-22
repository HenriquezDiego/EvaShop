using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaShop.Data.Migrations
{
    public partial class SeederArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articulos",
                columns: new[] { "Id", "Descripcion", "ForMan", "Imagenes", "Nombre", "SubCategoriaId", "WishListId" },
                values: new object[,]
                {
                    { new Guid("15f3f10e-bf0a-4928-da17-08da3c25f9c1"), "Su tejido de secado rápido te mantendrá fresca todo el tiempo. Además, será doblemente tu favorito, ya que al ser doble faz, tienes dos prendas en una sola. Úsalo para trotar, bailar, montar en bicicleta, ir al gimnasio", false, "/imagenes/articulos/top celeste.jpg", "Top deportivo sin costuras doble faz", 1, null },
                    { new Guid("3076acf5-dec1-4066-da1b-08da3c25f9c1"), "¡Tendencias que tienes que probar! Antójate de este espectacular bralette romántico, femenino y ¡muy sexy! en encaje y tul. Sin arcos, abrochaduras, ni estructuras para máxima comodidad, toda la libertad que buscas.", false, "/imagenes/articulos/encaje_tres.jpg", "Bralette de cuello alto tipo crop top sin estructura", 2, null },
                    { new Guid("39cd5613-5683-4cea-da18-08da3c25f9c1"), " Cuenta con un tejido que bordea los laterales del busto que lo recoge y lo centra para que sientas todo en su lugar mientras realizas tus actividades deportivas", false, "/imagenes/articulos/top negro.jpg", "Top deportivo sin costuras doble faz", 1, null },
                    { new Guid("53747151-4819-4adc-da14-08da3c25f9c1"), "Top deportivo doble faz con tecnología seamless de pocas costuras para que sientas más comodidad cuando realices tus entrenamientos. Es una prenda liviana, ligera y muy suave al tacto. Cuenta con un tejido que bordea los laterales del busto que lo recoge y lo centra para que sientas todo en su lugar mientras realizas tus actividades deportivas", false, "/imagenes/articulos/top doble faz.jpg", "Top deportivo sin costuras doble faz", 1, null },
                    { new Guid("5e60f0e9-7aad-4428-da1a-08da3c25f9c1"), "Brasier de realce alto con copas profundas, ideal para busto mediano y grande. Su diseño es de máximo cubrimiento del busto y de la espalda, haciendo que luzcas perfecta.", false, "/imagenes/articulos/encaje_dos.jpg", "Brasier balconet de realce alto en encaje con máximo cubrimiento de espalda", 2, null },
                    { new Guid("6836d141-693c-49ab-da15-08da3c25f9c1"), "Con este top, te sentirás muy cómoda a la hora de hacer ejercicio gracias a su tecnología de ajuste perfecto sin cortes ni costuras. Te brindará un excelente soporte; su fajón ancho en la base del busto y su buen cubrimiento en escote, sisa y espalda permitirán que tu busto esté siempre en su lugar", false, "/imagenes/articulos/deportivo crop top.jpg", "Top deportivo estilo crop top sin costuras acanalado de secado rápido", 1, null },
                    { new Guid("85913343-0ffa-453d-da1c-08da3c25f9c1"), "Este brasier básico con copas lisas cuenta con delicados toques de encaje en las cargaderas y la base, que le dan un look diferenciado y sofisticado.", false, "/imagenes/articulos/encaje_cuatro.jpg", "Brasier básico con copas suaves y ligeras Bra sexy essential", 2, null },
                    { new Guid("86874437-431d-4745-da1d-08da3c25f9c1"), "No tiene, arco,y sus copas están elaboradas en encaje, para que puedas disfrutar de una modelación totalmente natural. Cuenta con una banda elástica bajo el busto, que te da mayor soporte.", false, "/imagenes/articulos/encaje_cinco.jpg", "Bralette triangular en tul y encaje elástico en base del busto", 2, null },
                    { new Guid("a9a00ad2-f3e3-4bac-da16-08da3c25f9c1"), "Cuenta con un tejido que bordea los laterales del busto que lo recoge y lo centra para que sientas todo en su lugar mientras realizas tus actividades deportivas ¡Tu busto lucirá muy natural!", false, "/imagenes/articulos/top deportivo.jpg", "Top deportivo sin costuras doble faz", 1, null },
                    { new Guid("f8ccb148-e1c5-4e99-da19-08da3c25f9c1"), " Este brasier es la sensualidad hecha prenda, ya que está elaborado completamente en encaje y tul. Cuenta con muy buen soporte gracias a sus arcos internos y con excelente cubrimiento en la espalda.", false, "/imagenes/articulos/encaje_uno.jpg", "Brasier tipo bralette en encaje y transparencias", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Inventarios",
                columns: new[] { "Id", "ArticuloId", "CantidadMinima", "Costo", "Existencias", "PrecioDeVenta" },
                values: new object[,]
                {
                    { 1, new Guid("53747151-4819-4adc-da14-08da3c25f9c1"), 3, 40.00m, 25, 45m },
                    { 2, new Guid("6836d141-693c-49ab-da15-08da3c25f9c1"), 3, 40.00m, 20, 45m },
                    { 3, new Guid("a9a00ad2-f3e3-4bac-da16-08da3c25f9c1"), 3, 40.00m, 15, 45m },
                    { 4, new Guid("15f3f10e-bf0a-4928-da17-08da3c25f9c1"), 3, 40.00m, 10, 45m },
                    { 5, new Guid("39cd5613-5683-4cea-da18-08da3c25f9c1"), 3, 40.00m, 23, 45m },
                    { 6, new Guid("f8ccb148-e1c5-4e99-da19-08da3c25f9c1"), 3, 45.00m, 23, 50m },
                    { 7, new Guid("5e60f0e9-7aad-4428-da1a-08da3c25f9c1"), 3, 40.00m, 19, 45m },
                    { 8, new Guid("3076acf5-dec1-4066-da1b-08da3c25f9c1"), 3, 40.00m, 15, 45m },
                    { 9, new Guid("85913343-0ffa-453d-da1c-08da3c25f9c1"), 3, 45.00m, 15, 50m },
                    { 10, new Guid("86874437-431d-4745-da1d-08da3c25f9c1"), 3, 30.00m, 5, 35m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inventarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inventarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inventarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Inventarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Inventarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Inventarios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Inventarios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Inventarios",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Inventarios",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("15f3f10e-bf0a-4928-da17-08da3c25f9c1"));

            migrationBuilder.DeleteData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("3076acf5-dec1-4066-da1b-08da3c25f9c1"));

            migrationBuilder.DeleteData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("39cd5613-5683-4cea-da18-08da3c25f9c1"));

            migrationBuilder.DeleteData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("53747151-4819-4adc-da14-08da3c25f9c1"));

            migrationBuilder.DeleteData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("5e60f0e9-7aad-4428-da1a-08da3c25f9c1"));

            migrationBuilder.DeleteData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("6836d141-693c-49ab-da15-08da3c25f9c1"));

            migrationBuilder.DeleteData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("85913343-0ffa-453d-da1c-08da3c25f9c1"));

            migrationBuilder.DeleteData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("86874437-431d-4745-da1d-08da3c25f9c1"));

            migrationBuilder.DeleteData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("a9a00ad2-f3e3-4bac-da16-08da3c25f9c1"));

            migrationBuilder.DeleteData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: new Guid("f8ccb148-e1c5-4e99-da19-08da3c25f9c1"));
        }
    }
}
