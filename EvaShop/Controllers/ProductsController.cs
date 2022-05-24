using AutoMapper;
using EvaShop.Data;
using EvaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EvaShop.Controllers
{
    public class ProductsController : Controller
    {
        private const string SessionKeyName = "_Bag";
        private readonly ApplicationDbContext _appDbContext;
        private readonly IMapper _mapper;

        public ProductsController(ApplicationDbContext appDbContext,
            IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public IActionResult Index(bool? forMan,[FromQuery] int? categoriaId)
        {
            var inventarios = _appDbContext.Inventarios
                .Include(i=>i.Articulo)
                .ThenInclude(i=>i.SubCategoria)
                .ThenInclude(i=>i.Categoria)
                .Where(i=>i.Existencias > 0)
                .ToList();

            if(categoriaId != null) inventarios = inventarios.Where(i=>i.Articulo.SubCategoria.Categoria.Id == categoriaId).ToList();

            if (forMan != null) inventarios = inventarios
                .Where(i => i.Articulo.ForMan == forMan)
                .ToList();

            var result = _mapper.Map<IEnumerable<InventarioViewModel>>(inventarios);
            var categorias = _appDbContext.Categorias.ToList();
            ViewBag.Categorias = categorias;

            return View(result);
        }

        public IActionResult Add(string id,[FromQuery]int? quantity)
        {
            var bag = HttpContext.Session.GetString(SessionKeyName);

            if (bag != null)
            {
                bag += "," + id;
            }
            else
            {
                bag = id;   
            }

            if (quantity != null)
            {
                for (var i = 0; i < quantity-1; i++)
                {
                    bag += "," + id;
                }

            }

            HttpContext.Session.SetString(SessionKeyName,bag);
            var count = bag.Split(',').Length;
            return new JsonResult(count);
        }
    }
}
