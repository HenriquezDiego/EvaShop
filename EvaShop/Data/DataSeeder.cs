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
                Id = 1,
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
                Id = 1,
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
                Id = 1,
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
    }
}
