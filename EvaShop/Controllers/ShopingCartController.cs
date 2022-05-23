using AutoMapper;
using EvaShop.Data;
using EvaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EvaShop.Controllers
{
    public class ShopingCartController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly IMapper _mapper;

        public ShopingCartController(ApplicationDbContext appDbContext,
            IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public ActionResult Index()
        {
            var bag = HttpContext.Session.GetString("_Bag");
            if (string.IsNullOrEmpty(bag)) return Redirect("Home");
            var myShopingCart = bag.Split(',').ToList();
            var inventarios = _appDbContext.Inventarios
                .Include(i=>i.Articulo)
                .ThenInclude(i=>i.SubCategoria)
                .ThenInclude(i=>i.Categoria)
                .ToList();

            inventarios = inventarios.Where(i => myShopingCart.Any(m => m == i.ArticuloId.ToString())).ToList();

            return View(_mapper.Map<IEnumerable<InventarioViewModel>>(inventarios));
        }

    }
}
