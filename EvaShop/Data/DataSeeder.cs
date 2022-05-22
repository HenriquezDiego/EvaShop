using EvaShop.Models;

namespace EvaShop.Data
{
    public static class DataSeeder
    {
        public static readonly List<Estado> Estados = Enum.GetValues(typeof(EstadosIds))
        .Cast<EstadosIds>()
        .Select(e => new Estado
        {
            Id = e,
            Nombre = e.ToString()
        }).ToList();

        public static readonly List<Categoria> Categorias = new List<Categoria>()
        {
            new Categoria
            {
                Id = 1,
                Nombre = "Brasieres",
                SubCategorias = new List<SubCategoria>
                {
                    new SubCategoria
                    {
                        Id = 1,
                        Nombre = "Brasieres deportivos"
                    },
                    new SubCategoria
                    {
                        Id = 2,
                        Nombre = "Encaje"
                    },
                    new SubCategoria
                    {
                        Id = 3,
                        Nombre = "Brasieres Strapless"
                    },
                    new SubCategoria
                    {
                        Id = 4,
                        Nombre = "Broche delantero"
                    },
                    new SubCategoria
                    {
                        Id = 5,
                        Nombre = "Con relleno"
                    }

                }
            },
            new Categoria
            {
                Id = 2,
                Nombre = "Panties",
                SubCategorias = new List<SubCategoria>
                {
                    new SubCategoria
                    {
                        Id = 6,
                        Nombre = "Tangas Brasileras"
                    },
                    new SubCategoria
                    {
                        Id = 7,
                        Nombre = "Cacheteros"
                    },
                    new SubCategoria
                    {
                        Id = 8,
                        Nombre = "Clasicos"
                    }
                }
            },
            new Categoria
            {
                Id = 3,
                Nombre = "Trajes de baño",
                SubCategorias = new List<SubCategoria>
                {
                    new SubCategoria
                    {
                        Id = 9,
                        Nombre = "Bikinis"
                    },
                    new SubCategoria
                    {
                        Id = 10,
                        Nombre = "Una sola pieza"
                    },
                    new SubCategoria
                    {
                        Id = 11,
                        Nombre = "Dos piezas"
                    }
                }
            },
            new Categoria
            {
                Id = 4,
                Nombre = "Lenceria",
                SubCategorias = new List<SubCategoria>
                {
                    new SubCategoria
                    {
                        Id = 12,
                        Nombre = "Body Doll"
                    }
                }
            }

        };

        public static readonly List<Articulo> Articulos = new List<Articulo>()
        {
            new Articulo {
                Id=1,
                Nombre="Top deportivo sin costuras doble faz",
                Descripcion="Top deportivo doble faz con tecnología seamless de pocas costuras " +
                "para que sientas más comodidad cuando realices tus entrenamientos. Es una prenda " +
                "liviana, ligera y muy suave al tacto. Cuenta con un tejido que bordea los laterales" +
                " del busto que lo recoge y lo centra para que sientas todo en su lugar mientras realizas" +
                " tus actividades deportivas",
                Imagenes="/imagenes/articulos/top doble faz.jpg",
                SubCategoriaId= 1
            },
            new Articulo {
                Id=2,
                Nombre="Top deportivo estilo crop top sin costuras acanalado de secado rápido",
                Descripcion="Con este top, te sentirás muy cómoda a la hora de hacer ejercicio gracias" +
                " a su tecnología de ajuste perfecto sin cortes ni costuras. Te brindará un excelente soporte;" +
                " su fajón ancho en la base del busto y su buen cubrimiento en escote, sisa y espalda permitirán" +
                " que tu busto esté siempre en su lugar",
                Imagenes="/imagenes/articulos/deportivo crop top.jpg",
                SubCategoriaId= 1
            },
            new Articulo {
                Id=3,
                Nombre="Top deportivo sin costuras doble faz",
                Descripcion="Cuenta con un tejido que bordea los laterales del busto que lo recoge y lo centra para" +
                 " que sientas todo en su lugar mientras realizas tus actividades deportivas ¡Tu busto lucirá muy" +
                 " natural!",
                Imagenes="/imagenes/articulos/top deportivo.jpg",
                SubCategoriaId= 1
            },
            new Articulo {
                Id=4,
                Nombre="Top deportivo sin costuras doble faz",
                Descripcion="Su tejido de secado rápido te mantendrá fresca todo el tiempo. Además, será" +
                  " doblemente tu favorito, ya que al ser doble faz, tienes dos prendas en una sola. Úsalo" +
                  " para trotar, bailar, montar en bicicleta, ir al gimnasio",
                Imagenes="/imagenes/articulos/top celeste.jpg",
                SubCategoriaId= 1
            },
            new Articulo {
                Id=5,
                Nombre="Top deportivo sin costuras doble faz",
                Descripcion=" Cuenta con un tejido que bordea los laterales del busto que lo recoge y lo centra" +
                   " para que sientas todo en su lugar mientras realizas tus actividades deportivas",
                Imagenes="/imagenes/articulos/top negro.jpg",
                SubCategoriaId= 1
            },
            new Articulo {
                Id=6,
                Nombre="Brasier tipo bralette en encaje y transparencias",
                Descripcion=" Este brasier es la sensualidad hecha prenda, ya que está elaborado completamente en" +
                     " encaje y tul. Cuenta con muy buen soporte gracias a sus arcos internos y con excelente " +
                     "cubrimiento en la espalda.",
                Imagenes="/imagenes/articulos/encaje_uno.jpg",
                SubCategoriaId= 2
            },
            new Articulo {
                Id=7,
                Nombre="Brasier balconet de realce alto en encaje con máximo cubrimiento de espalda",
                Descripcion="Brasier de realce alto con copas profundas, ideal para busto mediano y grande." +
                " Su diseño es de máximo cubrimiento del busto y de la espalda, haciendo que luzcas perfecta.",
                Imagenes="/imagenes/articulos/encaje_dos.jpg",
                SubCategoriaId= 2
            },
             new Articulo {
                Id=8,
                Nombre="Bralette de cuello alto tipo crop top sin estructura",
                Descripcion="¡Tendencias que tienes que probar! Antójate de este espectacular bralette romántico," +
                 " femenino y ¡muy sexy! en encaje y tul. Sin arcos, abrochaduras, ni estructuras para máxima comodidad," +
                 " toda la libertad que buscas.",
                Imagenes="/imagenes/articulos/encaje_tres.jpg",
                SubCategoriaId= 2
            },
             new Articulo {
                Id=9,
                Nombre="Brasier básico con copas suaves y ligeras Bra sexy essential",
                Descripcion="Este brasier básico con copas lisas cuenta con delicados toques de encaje en las cargaderas y" +
                 " la base, que le dan un look diferenciado y sofisticado.",
                Imagenes="/imagenes/articulos/encaje_cuatro.jpg",
                SubCategoriaId= 2
            },
             new Articulo {
                Id=10,
                Nombre="Bralette triangular en tul y encaje elástico en base del busto",
                Descripcion="No tiene, arco,y sus copas están elaboradas en encaje, para que puedas disfrutar de una" +
                 " modelación totalmente natural. Cuenta con una banda elástica bajo el busto, que te da mayor soporte.",
                Imagenes="/imagenes/articulos/encaje_cinco.jpg",
                SubCategoriaId= 2
            }
        };

        public static readonly List<Inventario> Inventarios = new List<Inventario>()
        {
            new Inventario
            {
                Id= 1,
                ArticuloId= 1,
                Costo= 40.00,
                PrecioDeVenta= 45,
                CantidadMinima=3,
                Existencias=25
            },
              new Inventario
            {
                Id= 2,
                ArticuloId= 2,
                Costo= 40.00,
                PrecioDeVenta= 45,
                CantidadMinima=3,
                Existencias=20
            },
                new Inventario
            {
                Id= 3,
                ArticuloId= 3,
                Costo= 40.00,
                PrecioDeVenta= 45,
                CantidadMinima=3,
                Existencias=15
            },
                new Inventario
            {
                Id= 4,
                ArticuloId= 4,
                Costo= 40.00,
                PrecioDeVenta= 45,
                CantidadMinima=3,
                Existencias=10
            },
                new Inventario
            {
                Id= 5,
                ArticuloId= 5,
                Costo= 40.00,
                PrecioDeVenta= 45,
                CantidadMinima=3,
                Existencias=23
            },
                new Inventario
            {
                Id= 6,
                ArticuloId= 6,
                Costo= 45.00,
                PrecioDeVenta= 50,
                CantidadMinima=3,
                Existencias=23
            },
                new Inventario
            {
                Id= 7,
                ArticuloId= 7,
                Costo= 40.00,
                PrecioDeVenta= 45,
                CantidadMinima=3,
                Existencias=19
            },
                new Inventario
            {
                Id= 8,
                ArticuloId= 8,
                Costo= 40.00,
                PrecioDeVenta= 45,
                CantidadMinima=3,
                Existencias=15
            },
                new Inventario
            {
                Id= 9,
                ArticuloId= 9,
                Costo= 45.00,
                PrecioDeVenta= 50,
                CantidadMinima=3,
                Existencias=15
            },
                new Inventario
            {
                Id= 10,
                ArticuloId= 10,
                Costo= 30.00,
                PrecioDeVenta= 35,
                CantidadMinima=3,
                Existencias=5
            }

        };
        
    }
}
