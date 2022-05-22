using EvaShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace EvaShop.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class SeederController : ControllerBase
    {
        public ApplicationDbContext AppDbContext { get; }

        public SeederController(ApplicationDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            AppDbContext.Articulos.AddRange(DataSeeder.Articulos);
            if (AppDbContext.SaveChanges()<0) return BadRequest();
            return Ok();
        }
    }
}
