namespace EvaShop.ViewModels
{
    public class ShopingCartViewModel
    {
        public int Id { get; set; }
        public Guid ArticuloId { get; set; }
        public string Articulo { get; set; }
        public string ArticuloImagenes { get; set; }
        public bool ArticuloForMan { get; set; }
        public int Existencias { get; set; }
        public decimal PrecioDeVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal => PrecioDeVenta * Cantidad;
    }
}
