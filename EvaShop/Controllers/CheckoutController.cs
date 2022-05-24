using AutoMapper;
using EvaShop.Data;
using EvaShop.Inputs;
using EvaShop.Models;
using EvaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
            ViewBag.CardModalClass = "";
            ViewBag.CardModalStyle = "";
            ViewBag.BodyClass = "";
            ViewBag.Backdrop = "";
            return View(billing);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CheckoutInput model)
        {
            var cliente = _mapper.Map<Cliente>(model);
            _appDbContext.Clientes.Add(cliente);
            var billing = HttpContext.Session.GetIEnumerable<ShopingCartViewModel>("billing");
            if (billing == null) return BadRequest();
            await _appDbContext.SaveChangesAsync();
            var pedido = new Pedido
            {
                ClienteId = cliente.Id,
                Fecha = new DateTime(),
                EstadoId = EstadosIds.EnProceso,
                Numero = new Guid().ToString(),
                TotalVenta = billing.Sum(b=>b.SubTotal),
                DireccionDeEnvio = cliente.Direccion
            };
            var detalles = _mapper.Map<IEnumerable<Detalle>>(billing);
            pedido.Detellas = detalles.ToList();
            _appDbContext.Pedidos.Add(pedido);
            await _appDbContext.SaveChangesAsync();
            ViewBag.CardModalStyle = "display:block; padding-right:17px";
            ViewBag.CardModalClass = "show";
            ViewBag.BodyClass = "modal-open";
            ViewBag.Backdrop = "<div class='modal-backdrop fade show'></div>";
            return View("Index",billing);
        }
    }
}
