using EvaShop.Data.Core;
using EvaShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EvaShop.Data.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(DbContext context) : base(context)
        {
        }
    }
}
