using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaShop.Inputs
{
    public class ArticuloInput
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public IFormFile Imagen { get; set; }
        public string CodigoDeBarra { get; set; }
        public bool ForMan { get; set; }
        public int SubCategoriaId { get; set; }
    }
}
