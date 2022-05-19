using EvaShop.Data.Core;
using EvaShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EvaShop.Data.Repositories
{
    public class DescuentoRepository : Repository<Descuento>, IDescuentoRepository
    {
        public DescuentoRepository(DbContext context) : base(context)
        {
        }
    }
}
