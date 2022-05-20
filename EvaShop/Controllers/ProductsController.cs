using Microsoft.AspNetCore.Mvc;

namespace EvaShop.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
