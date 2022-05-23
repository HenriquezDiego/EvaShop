using Microsoft.AspNetCore.Mvc;

namespace EvaShop.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
