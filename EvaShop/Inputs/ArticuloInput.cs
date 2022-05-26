namespace EvaShop.Inputs
{
    public class ArticuloInput
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public IFormFile Imagen { get; set; }
        public bool ForMan { get; set; }
        public int SubCategoriaId { get; set; }
    }
}
