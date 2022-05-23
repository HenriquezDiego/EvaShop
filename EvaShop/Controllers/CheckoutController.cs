using AutoMapper;
using EvaShop.Data;
using EvaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EvaShop.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly IMapper _mapper;

        public CheckoutController(ApplicationDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var bag = HttpContext.Session.GetString("_Bag");
            if (string.IsNullOrEmpty(bag)) return Redirect("Home");
            var myShopingCart = bag.Split(',').ToList();
            var group = myShopingCart.GroupBy(x => x).Select((x) => new
            {
                x.Key,
                x.ToList().Count
            }).ToList();
            var articulos = _appDbContext.Inventarios
                .Include(i=>i.Articulo)
                .ThenInclude(i=>i.SubCategoria)
                .ThenInclude(i=>i.Categoria)
                .ToList();
            

            articulos = articulos.Where(i => myShopingCart.Any(m => m == i.ArticuloId.ToString())).ToList();
            var result = _mapper.Map<IEnumerable<ShopingCartViewModel>>(articulos);
            foreach (var item in result)
            {
                item.Cantidad = group.FirstOrDefault(g => g.Key == item.ArticuloId.ToString())?.Count ?? 0;
            }
            return View(result);
        }
    }
}
