using EvaShop.Data.Core;
using EvaShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EvaShop.Data.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(DbContext context) : base(context)
        {
        }
    }
}
