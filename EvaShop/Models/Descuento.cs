namespace EvaShop.Models
{
    public class Descuento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public Articulo Articulo { get; set; }
        public decimal Valor { get; set; }
    }
}
