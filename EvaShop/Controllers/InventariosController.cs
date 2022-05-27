using AutoMapper;
using EvaShop.Data;
using EvaShop.Inputs;
using EvaShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EvaShop.Controllers
{
    public class InventariosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly List<Articulo> _articulos;
        public InventariosController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _articulos = _context.Articulos.ToList();
        }

        // GET: Inventarios
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Inventarios.Include(i => i.Articulo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Inventarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventario = await _context.Inventarios
                .Include(i => i.Articulo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventario == null)
            {
                return NotFound();
            }

            return View(inventario);
        }

        // GET: Inventarios/Create
        public IActionResult Create()
        {
            var lista = _context.Inventarios.Select(i => i.ArticuloId);
            var articulos = _articulos.Where(a=>lista.All(l=>l != a.Id));
            ViewData["ArticuloId"] = new SelectList(articulos, "Id", "Nombre");
            
            return View();
        }

        // POST: Inventarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(InventarioInput model)
        {
            var inventario = _mapper.Map<Inventario>(model);
            if (ModelState.IsValid)
            {
                _context.Add(inventario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArticuloId"] = new SelectList(_context.Articulos, "Id", "Nombre", model.ArticuloId);
            return View(inventario);
        }

        // GET: Inventarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventario = await _context.Inventarios.FindAsync(id);
            if (inventario == null)
            {
                return NotFound();
            }
            ViewData["ArticuloId"] = new SelectList(_context.Articulos, "Id", "Id", inventario.ArticuloId);
            return View(inventario);
        }

        // POST: Inventarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ArticuloId,Existencias,Costo,PrecioDeVenta,CantidadMinima")] Inventario inventario)
        {
            if (id != inventario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventarioExists(inventario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArticuloId"] = new SelectList(_context.Articulos, "Id", "Id", inventario.ArticuloId);
            return View(inventario);
        }

        // GET: Inventarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventario = await _context.Inventarios
                .Include(i => i.Articulo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventario == null)
            {
                return NotFound();
            }

            return View(inventario);
        }

        // POST: Inventarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventario = await _context.Inventarios.FindAsync(id);
            if (inventario != null)
            {
                _context.Inventarios.Remove(inventario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventarioExists(int id)
        {
          return (_context.Inventarios.Any(e => e.Id == id));
        }
    }
}
