namespace EvaShop.Models
{
    public class Detalle
    {
        public Guid Id { get; set; }
        public Guid ArticuloId { get; set; }
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario  { get; set; }
        public decimal Descuento { get; set; }

    }
}
