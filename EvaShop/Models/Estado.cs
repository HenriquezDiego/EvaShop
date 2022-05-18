namespace EvaShop.Models
{
    public class Estado
    {
        public EstadosIds Id { get; set; }
        public string Nombre { get; set; }
    }

    public enum EstadosIds
    {
        /// <summary>
        /// 0
        /// </summary>
        EnProceso = 0,
        /// <summary>
        /// 1
        /// </summary>
        Facturado = 1,
        /// <summary>
        /// 2
        /// </summary>
        Enviado = 2,
        /// <summary>
        /// 3
        /// </summary>
        Recibido = 3,
        /// <summary>
        /// 4
        /// </summary>
        Cancelado = 4,
    }
}