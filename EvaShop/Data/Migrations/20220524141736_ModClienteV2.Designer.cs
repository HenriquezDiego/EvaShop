﻿// <auto-generated />
using System;
using EvaShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EvaShop.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220524141736_ModClienteV2")]
    partial class ModClienteV2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EvaShop.Models.Articulo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CodigoDeBarra")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ForMan")
                        .HasColumnType("bit");

                    b.Property<string>("Imagenes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubCategoriaId")
                        .HasColumnType("int");

                    b.Property<int?>("WishListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoriaId");

                    b.HasIndex("WishListId");

                    b.ToTable("Articulos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("53747151-4819-4adc-da14-08da3c25f9c1"),
                            Descripcion = "Top deportivo doble faz con tecnología seamless de pocas costuras para que sientas más comodidad cuando realices tus entrenamientos. Es una prenda liviana, ligera y muy suave al tacto. Cuenta con un tejido que bordea los laterales del busto que lo recoge y lo centra para que sientas todo en su lugar mientras realizas tus actividades deportivas",
                            ForMan = false,
                            Imagenes = "/imagenes/articulos/top doble faz.jpg",
                            Nombre = "Top deportivo sin costuras doble faz",
                            SubCategoriaId = 1
                        },
                        new
                        {
                            Id = new Guid("6836d141-693c-49ab-da15-08da3c25f9c1"),
                            Descripcion = "Con este top, te sentirás muy cómoda a la hora de hacer ejercicio gracias a su tecnología de ajuste perfecto sin cortes ni costuras. Te brindará un excelente soporte; su fajón ancho en la base del busto y su buen cubrimiento en escote, sisa y espalda permitirán que tu busto esté siempre en su lugar",
                            ForMan = false,
                            Imagenes = "/imagenes/articulos/deportivo crop top.jpg",
                            Nombre = "Top deportivo estilo crop top sin costuras acanalado de secado rápido",
                            SubCategoriaId = 1
                        },
                        new
                        {
                            Id = new Guid("a9a00ad2-f3e3-4bac-da16-08da3c25f9c1"),
                            Descripcion = "Cuenta con un tejido que bordea los laterales del busto que lo recoge y lo centra para que sientas todo en su lugar mientras realizas tus actividades deportivas ¡Tu busto lucirá muy natural!",
                            ForMan = false,
                            Imagenes = "/imagenes/articulos/top deportivo.jpg",
                            Nombre = "Top deportivo sin costuras doble faz",
                            SubCategoriaId = 1
                        },
                        new
                        {
                            Id = new Guid("15f3f10e-bf0a-4928-da17-08da3c25f9c1"),
                            Descripcion = "Su tejido de secado rápido te mantendrá fresca todo el tiempo. Además, será doblemente tu favorito, ya que al ser doble faz, tienes dos prendas en una sola. Úsalo para trotar, bailar, montar en bicicleta, ir al gimnasio",
                            ForMan = false,
                            Imagenes = "/imagenes/articulos/top celeste.jpg",
                            Nombre = "Top deportivo sin costuras doble faz",
                            SubCategoriaId = 1
                        },
                        new
                        {
                            Id = new Guid("39cd5613-5683-4cea-da18-08da3c25f9c1"),
                            Descripcion = " Cuenta con un tejido que bordea los laterales del busto que lo recoge y lo centra para que sientas todo en su lugar mientras realizas tus actividades deportivas",
                            ForMan = false,
                            Imagenes = "/imagenes/articulos/top negro.jpg",
                            Nombre = "Top deportivo sin costuras doble faz",
                            SubCategoriaId = 1
                        },
                        new
                        {
                            Id = new Guid("f8ccb148-e1c5-4e99-da19-08da3c25f9c1"),
                            Descripcion = " Este brasier es la sensualidad hecha prenda, ya que está elaborado completamente en encaje y tul. Cuenta con muy buen soporte gracias a sus arcos internos y con excelente cubrimiento en la espalda.",
                            ForMan = false,
                            Imagenes = "/imagenes/articulos/encaje_uno.jpg",
                            Nombre = "Brasier tipo bralette en encaje y transparencias",
                            SubCategoriaId = 2
                        },
                        new
                        {
                            Id = new Guid("5e60f0e9-7aad-4428-da1a-08da3c25f9c1"),
                            Descripcion = "Brasier de realce alto con copas profundas, ideal para busto mediano y grande. Su diseño es de máximo cubrimiento del busto y de la espalda, haciendo que luzcas perfecta.",
                            ForMan = false,
                            Imagenes = "/imagenes/articulos/encaje_dos.jpg",
                            Nombre = "Brasier balconet de realce alto en encaje con máximo cubrimiento de espalda",
                            SubCategoriaId = 2
                        },
                        new
                        {
                            Id = new Guid("3076acf5-dec1-4066-da1b-08da3c25f9c1"),
                            Descripcion = "¡Tendencias que tienes que probar! Antójate de este espectacular bralette romántico, femenino y ¡muy sexy! en encaje y tul. Sin arcos, abrochaduras, ni estructuras para máxima comodidad, toda la libertad que buscas.",
                            ForMan = false,
                            Imagenes = "/imagenes/articulos/encaje_tres.jpg",
                            Nombre = "Bralette de cuello alto tipo crop top sin estructura",
                            SubCategoriaId = 2
                        },
                        new
                        {
                            Id = new Guid("85913343-0ffa-453d-da1c-08da3c25f9c1"),
                            Descripcion = "Este brasier básico con copas lisas cuenta con delicados toques de encaje en las cargaderas y la base, que le dan un look diferenciado y sofisticado.",
                            ForMan = false,
                            Imagenes = "/imagenes/articulos/encaje_cuatro.jpg",
                            Nombre = "Brasier básico con copas suaves y ligeras Bra sexy essential",
                            SubCategoriaId = 2
                        },
                        new
                        {
                            Id = new Guid("86874437-431d-4745-da1d-08da3c25f9c1"),
                            Descripcion = "No tiene, arco,y sus copas están elaboradas en encaje, para que puedas disfrutar de una modelación totalmente natural. Cuenta con una banda elástica bajo el busto, que te da mayor soporte.",
                            ForMan = false,
                            Imagenes = "/imagenes/articulos/encaje_cinco.jpg",
                            Nombre = "Bralette triangular en tul y encaje elástico en base del busto",
                            SubCategoriaId = 2
                        });
                });

            modelBuilder.Entity("EvaShop.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Brasieres"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Panties"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Trajes de baño"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Lenceria"
                        });
                });

            modelBuilder.Entity("EvaShop.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dui")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("EvaShop.Models.Descuento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("ArticuloId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,5)");

                    b.HasKey("Id");

                    b.HasIndex("ArticuloId");

                    b.ToTable("Descuentos");
                });

            modelBuilder.Entity("EvaShop.Models.Detalle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArticuloId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Descuento")
                        .HasColumnType("decimal(18,5)");

                    b.Property<Guid?>("PedidoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(18,5)");

                    b.HasKey("Id");

                    b.HasIndex("ArticuloId");

                    b.HasIndex("PedidoId");

                    b.ToTable("Detalles");
                });

            modelBuilder.Entity("EvaShop.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("EvaShop.Models.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("ArticuloId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CantidadMinima")
                        .HasColumnType("int");

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(18,5)");

                    b.Property<int>("Existencias")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioDeVenta")
                        .HasColumnType("decimal(18,5)");

                    b.HasKey("Id");

                    b.HasIndex("ArticuloId");

                    b.ToTable("Inventarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticuloId = new Guid("53747151-4819-4adc-da14-08da3c25f9c1"),
                            CantidadMinima = 3,
                            Costo = 40.00m,
                            Existencias = 25,
                            PrecioDeVenta = 45m
                        },
                        new
                        {
                            Id = 2,
                            ArticuloId = new Guid("6836d141-693c-49ab-da15-08da3c25f9c1"),
                            CantidadMinima = 3,
                            Costo = 40.00m,
                            Existencias = 20,
                            PrecioDeVenta = 45m
                        },
                        new
                        {
                            Id = 3,
                            ArticuloId = new Guid("a9a00ad2-f3e3-4bac-da16-08da3c25f9c1"),
                            CantidadMinima = 3,
                            Costo = 40.00m,
                            Existencias = 15,
                            PrecioDeVenta = 45m
                        },
                        new
                        {
                            Id = 4,
                            ArticuloId = new Guid("15f3f10e-bf0a-4928-da17-08da3c25f9c1"),
                            CantidadMinima = 3,
                            Costo = 40.00m,
                            Existencias = 10,
                            PrecioDeVenta = 45m
                        },
                        new
                        {
                            Id = 5,
                            ArticuloId = new Guid("39cd5613-5683-4cea-da18-08da3c25f9c1"),
                            CantidadMinima = 3,
                            Costo = 40.00m,
                            Existencias = 23,
                            PrecioDeVenta = 45m
                        },
                        new
                        {
                            Id = 6,
                            ArticuloId = new Guid("f8ccb148-e1c5-4e99-da19-08da3c25f9c1"),
                            CantidadMinima = 3,
                            Costo = 45.00m,
                            Existencias = 23,
                            PrecioDeVenta = 50m
                        },
                        new
                        {
                            Id = 7,
                            ArticuloId = new Guid("5e60f0e9-7aad-4428-da1a-08da3c25f9c1"),
                            CantidadMinima = 3,
                            Costo = 40.00m,
                            Existencias = 19,
                            PrecioDeVenta = 45m
                        },
                        new
                        {
                            Id = 8,
                            ArticuloId = new Guid("3076acf5-dec1-4066-da1b-08da3c25f9c1"),
                            CantidadMinima = 3,
                            Costo = 40.00m,
                            Existencias = 15,
                            PrecioDeVenta = 45m
                        },
                        new
                        {
                            Id = 9,
                            ArticuloId = new Guid("85913343-0ffa-453d-da1c-08da3c25f9c1"),
                            CantidadMinima = 3,
                            Costo = 45.00m,
                            Existencias = 15,
                            PrecioDeVenta = 50m
                        },
                        new
                        {
                            Id = 10,
                            ArticuloId = new Guid("86874437-431d-4745-da1d-08da3c25f9c1"),
                            CantidadMinima = 3,
                            Costo = 30.00m,
                            Existencias = 5,
                            PrecioDeVenta = 35m
                        });
                });

            modelBuilder.Entity("EvaShop.Models.Pedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionDeEnvio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalVenta")
                        .HasColumnType("decimal(18,5)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("EvaShop.Models.SubCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("SubCategoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Nombre = "Brasieres deportivos"
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 1,
                            Nombre = "Encaje"
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 1,
                            Nombre = "Brasieres Strapless"
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 1,
                            Nombre = "Broche delantero"
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 1,
                            Nombre = "Con relleno"
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 2,
                            Nombre = "Tangas Brasileras"
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 2,
                            Nombre = "Cacheteros"
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = 2,
                            Nombre = "Clasicos"
                        },
                        new
                        {
                            Id = 9,
                            CategoriaId = 3,
                            Nombre = "Bikinis"
                        },
                        new
                        {
                            Id = 10,
                            CategoriaId = 3,
                            Nombre = "Una sola pieza"
                        },
                        new
                        {
                            Id = 11,
                            CategoriaId = 3,
                            Nombre = "Dos piezas"
                        },
                        new
                        {
                            Id = 12,
                            CategoriaId = 4,
                            Nombre = "Body Doll"
                        });
                });

            modelBuilder.Entity("EvaShop.Models.WishList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<bool>("Comprado")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("WishList");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EvaShop.Models.Articulo", b =>
                {
                    b.HasOne("EvaShop.Models.SubCategoria", "SubCategoria")
                        .WithMany()
                        .HasForeignKey("SubCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvaShop.Models.WishList", null)
                        .WithMany("Articulos")
                        .HasForeignKey("WishListId");

                    b.Navigation("SubCategoria");
                });

            modelBuilder.Entity("EvaShop.Models.Descuento", b =>
                {
                    b.HasOne("EvaShop.Models.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Articulo");
                });

            modelBuilder.Entity("EvaShop.Models.Detalle", b =>
                {
                    b.HasOne("EvaShop.Models.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvaShop.Models.Pedido", null)
                        .WithMany("Detellas")
                        .HasForeignKey("PedidoId");

                    b.Navigation("Articulo");
                });

            modelBuilder.Entity("EvaShop.Models.Inventario", b =>
                {
                    b.HasOne("EvaShop.Models.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Articulo");
                });

            modelBuilder.Entity("EvaShop.Models.Pedido", b =>
                {
                    b.HasOne("EvaShop.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvaShop.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("EvaShop.Models.SubCategoria", b =>
                {
                    b.HasOne("EvaShop.Models.Categoria", "Categoria")
                        .WithMany("SubCategorias")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("EvaShop.Models.WishList", b =>
                {
                    b.HasOne("EvaShop.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EvaShop.Models.Categoria", b =>
                {
                    b.Navigation("SubCategorias");
                });

            modelBuilder.Entity("EvaShop.Models.Pedido", b =>
                {
                    b.Navigation("Detellas");
                });

            modelBuilder.Entity("EvaShop.Models.WishList", b =>
                {
                    b.Navigation("Articulos");
                });
#pragma warning restore 612, 618
        }
    }
}
