namespace EvaShop.Models
{
    public class Articulo
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagenes { get; set; }
        public string CodigoDeBarra { get; set; }
        public int SubCategoriaId { get; set; }
        public SubCategoria SubCategoria { get; set; }
    }
}
