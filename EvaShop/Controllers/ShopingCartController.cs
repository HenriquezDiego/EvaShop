using AutoMapper;
using EvaShop.Data;
using EvaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EvaShop.Controllers
{
    public class ShopingCartController : Controller
    {
        private const string SessionKeyName = "_Bag";
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
            var bag = HttpContext.Session.GetString(SessionKeyName);
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
            HttpContext.Session.SetObject("billing",result);
            return View(result);
        }

        public IActionResult Delete(string id)
        {
            var billing = HttpContext.Session.GetIEnumerable<ShopingCartViewModel>("billing");
            if(billing == null) return BadRequest();
            billing = billing.Where(x=>x.ArticuloId.ToString() != id);
            HttpContext.Session.SetObject("billing",billing);
            var bag = HttpContext.Session.GetString(SessionKeyName);
            if(bag == null) return BadRequest();
            var myShopingCart = bag.Split(',').ToList();
            if(!myShopingCart.Any()) return BadRequest();
            myShopingCart = myShopingCart.Where(x=>x != id).ToList();
            bag = string.Join(",", myShopingCart);
            HttpContext.Session.SetString(SessionKeyName,bag);
            return View("Index",billing);
        }
    }
}
