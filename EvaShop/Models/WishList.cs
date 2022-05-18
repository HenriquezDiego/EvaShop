namespace EvaShop.Models
{
    public class WishList
    {
        public int Id { get; set; }
        public bool Comprado { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<Articulo> Articulos { get; set; }

    }
}
