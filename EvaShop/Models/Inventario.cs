namespace EvaShop.Models
{
    public class Inventario
    {
        public int Id { get; set; }
        public Guid ArticuloId { get; set; }
        public Articulo Articulo { get; set; }
        public int Existencias { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioDeVenta { get; set; }
        public int CantidadMinima { get; set; }
    }
}
