namespace EvaShop.Models
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal TotalVenta { get; set; }
        public string DireccionDeEnvio { get; set; }
        public EstadosIds EstadoId { get; set; }
        public Estado Estado { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<Detalle> Detellas { get; set; }
    }
}
