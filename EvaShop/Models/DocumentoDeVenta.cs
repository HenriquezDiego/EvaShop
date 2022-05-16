namespace EvaShop.Models
{
    public class DocumentoDeVenta
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal TotalVenta { get; set; }
        public Estado Estado { get; set; }
        public List<Detalle> Detellas { get; set; }
    }
}
