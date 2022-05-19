using EvaShop.Data.Core;
using EvaShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EvaShop.Data.Repositories
{
    public class ArticuloRepository : Repository<Articulo>, IArticuloRepository
    {
        public ArticuloRepository(DbContext context) : base(context)
        {
        }
    }
}
