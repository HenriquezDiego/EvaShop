using EvaShop.Data;
using EvaShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace EvaShop.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;

        public CategoriesController(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var categorias = _appDbContext.Categorias.ToList();
            if(!categorias.Any()) categorias = new List<Categoria>();
            return View(categorias);
        }
    }
}
