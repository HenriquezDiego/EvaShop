using EvaShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace EvaShop.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View(new List<Categoria>());
        }
    }
}
