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
    }
}
