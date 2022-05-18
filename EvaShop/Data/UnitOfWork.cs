
using EvaShop.Data.Core;

namespace EvaShop.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _contaContext;

        public UnitOfWork(ApplicationDbContext contaContext)
        {
            _contaContext = contaContext;
        }

        public void Dispose()
        {
            _contaContext.Dispose();
        }
    }
}
