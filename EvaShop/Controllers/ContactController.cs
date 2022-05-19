using Microsoft.AspNetCore.Mvc;

namespace EvaShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
