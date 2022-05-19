
using EvaShop.Data.Core;
using EvaShop.Data.Repositories;

namespace EvaShop.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _contaContext;
        public IClienteRepository Cliente { get; }
        public ICategoriaRepository Categoria { get; }
        public IArticuloRepository Articulo { get; }
        public IDescuentoRepository Descuento { get; }
        public IInventarioRepository Inventario { get; }

        public UnitOfWork(ApplicationDbContext contaContext)
        {
            _contaContext = contaContext;
            Cliente = new ClienteRepository(_contaContext);
            Categoria = new CategoriaRepository(_contaContext);
            Articulo = new ArticuloRepository(_contaContext);
            Descuento = new DescuentoRepository(_contaContext);
            Inventario = new InventarioRepository(_contaContext);

        }

        public void Dispose()
        {
            _contaContext.Dispose();
        }

    }
}
