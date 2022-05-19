using EvaShop.Data.Core;
using EvaShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EvaShop.Data.Repositories
{
    public class InventarioRepository : Repository<Inventario>, IInventarioRepository
    {
        public InventarioRepository(DbContext context) : base(context)
        {
        }
    }
}
