using AutoMapper;
using EvaShop.Data;
using EvaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EvaShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly IMapper _mapper;

        public ProductsController(ApplicationDbContext appDbContext,
            IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public IActionResult Index(bool? forMan)
        {
            var inventarios = _appDbContext.Inventarios
                .Include(i=>i.Articulo)
                .ThenInclude(i=>i.SubCategoria)
                .ThenInclude(i=>i.Categoria)
                .ToList();

            if (forMan != null) inventarios = inventarios
                .Where(i => i.Articulo.ForMan == forMan)
                .ToList();

            var result = _mapper.Map<IEnumerable<InventarioViewModel>>(inventarios);

            return View(result);
        }
    }
}
