using Microsoft.AspNetCore.Mvc;

namespace EvaShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
