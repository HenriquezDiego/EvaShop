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
            var billing = HttpContext.Session.GetIEnumerable<ShopingCartViewModel>("billing");
            return View(billing);
        }
    }
}
