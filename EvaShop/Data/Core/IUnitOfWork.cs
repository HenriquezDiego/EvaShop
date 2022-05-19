using EvaShop.Data.Repositories;

namespace EvaShop.Data.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IClienteRepository Cliente { get; }
        ICategoriaRepository Categoria { get; }
        IArticuloRepository Articulo { get; }
        IDescuentoRepository Descuento { get; }
        IInventarioRepository Inventario { get; }
    }
}
