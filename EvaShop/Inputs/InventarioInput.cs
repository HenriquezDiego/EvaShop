namespace EvaShop.Inputs
{
    public class InventarioInput
    {
        public Guid ArticuloId { get; set; }
        public int Existencias { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioDeVenta { get; set; }
        public int CantidadMinima { get; set; }
    }
}
