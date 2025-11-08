using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgrInov.Data;
using AgrInov.Models;

namespace AgrInov.Controllers
{
    public class MetasController : Controller
    {
        private readonly AppDbContext _context;

        public MetasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Metas
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Meta.Include(m => m.Cultura);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Metas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meta = await _context.Meta
                .Include(m => m.Cultura)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meta == null)
            {
                return NotFound();
            }

            return View(meta);
        }

        // GET: Metas/Create
        public IActionResult Create()
        {
            ViewData["CulturaId"] = new SelectList(_context.Culturas, "Id", "Nome");
            return View();
        }

        // POST: Metas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataInicio,DataFim,Quantidade,CulturaId")] Meta meta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CulturaId"] = new SelectList(_context.Culturas, "Id", "Nome", meta.CulturaId);
            return View(meta);
        }

        // GET: Metas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meta = await _context.Meta.FindAsync(id);
            if (meta == null)
            {
                return NotFound();
            }
            ViewData["CulturaId"] = new SelectList(_context.Culturas, "Id", "Nome", meta.CulturaId);
            return View(meta);
        }

        // POST: Metas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataInicio,DataFim,Quantidade,CulturaId")] Meta meta)
        {
            if (id != meta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MetaExists(meta.Id))
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
            ViewData["CulturaId"] = new SelectList(_context.Culturas, "Id", "Nome", meta.CulturaId);
            return View(meta);
        }

        // GET: Metas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meta = await _context.Meta
                .Include(m => m.Cultura)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meta == null)
            {
                return NotFound();
            }

            return View(meta);
        }

        // POST: Metas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meta = await _context.Meta.FindAsync(id);
            if (meta != null)
            {
                _context.Meta.Remove(meta);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MetaExists(int id)
        {
            return _context.Meta.Any(e => e.Id == id);
        }
    }
}
