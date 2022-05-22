using System.Security.AccessControl;

namespace EvaShop.Models
{
    public class SubCategoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}