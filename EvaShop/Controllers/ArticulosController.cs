﻿using AutoMapper;
using EvaShop.Data;
using EvaShop.Inputs;
using EvaShop.Models;
using EvaShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EvaShop.Controllers
{
    public class ArticulosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public ArticulosController(ApplicationDbContext context, 
            IFileService fileService,
            IMapper mapper)
        {
            _context = context;
            _fileService = fileService;
            _mapper = mapper;
        }

        // GET: Articulos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Articulos
                .Include(a => a.SubCategoria)
                .ThenInclude(a=>a.Categoria);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Articulos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulos
                .Include(a => a.SubCategoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (articulo == null)
            {
                return NotFound();
            }

            return View(articulo);
        }

        // GET: Articulos/Create
        public IActionResult Create()
        {
            ViewData["SubCategoriaId"] = new SelectList(_context.Set<SubCategoria>(), "Id", "Nombre");
            return View();
        }

        // POST: Articulos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ArticuloInput model)
        {
            if (ModelState.IsValid)
            {
                var articulo = _mapper.Map<Articulo>(model);
                if (string.IsNullOrEmpty(articulo.Imagenes))
                {
                    articulo.Imagenes = await _fileService.Upload(model.Imagen, model.Nombre);
                }
                _context.Add(articulo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SubCategoriaId"] = new SelectList(_context.Set<SubCategoria>(), "Id", "Nombre", model.Nombre);
            return View(model);
        }

        // GET: Articulos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null) return NotFound();
            
            var articulo = await _context.Articulos.FindAsync(id);
            if (articulo == null)   return NotFound();
            ViewData["SubCategoriaId"] = new SelectList(_context.Set<SubCategoria>(), "Id", "Nombre", articulo.Nombre);
            return View(articulo);
        }

        // POST: Articulos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nombre,Descripcion,Imagenes,CodigoDeBarra,ForMan,SubCategoriaId")] Articulo articulo)
        {
            if (id != articulo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(articulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticuloExists(articulo.Id))
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
            ViewData["SubCategoriaId"] = new SelectList(_context.Set<SubCategoria>(), "Id", "Id", articulo.SubCategoriaId);
            return View(articulo);
        }

        // GET: Articulos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulos
                .Include(a => a.SubCategoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (articulo == null)
            {
                return NotFound();
            }

            return View(articulo);
        }

        // POST: Articulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var articulo = await _context.Articulos.FindAsync(id);
            if (articulo != null)
            {
                _context.Articulos.Remove(articulo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticuloExists(Guid id)
        {
          return (_context.Articulos.Any(e => e.Id == id));
        }
    }
}
