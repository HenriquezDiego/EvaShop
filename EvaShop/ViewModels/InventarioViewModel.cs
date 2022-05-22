namespace EvaShop.ViewModels
{
    public class InventarioViewModel
    {
        public int Id { get; set; }
        public Guid ArticuloId { get; set; }
        public string Articulo { get; set; }
        public string ArticuloDescripcion { get; set; }
        public string ArticuloImagenes { get; set; }
        public bool ArticuloForMan { get; set; }
        public int Existencias { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioDeVenta { get; set; }
        public int CantidadMinima { get; set; }
        public int SubCategoriaId { get; set; }
        public string SubCategoria { get; set; }
        public int CategoriaId { get; set; }
        public string Categoria { get; set; }

    }
}
