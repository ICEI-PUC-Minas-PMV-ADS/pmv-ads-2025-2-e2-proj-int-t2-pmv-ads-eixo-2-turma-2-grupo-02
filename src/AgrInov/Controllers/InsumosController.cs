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
    public class InsumosController : Controller
    {
        private readonly AppDbContext _context;

        public InsumosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Insumos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insumos.ToListAsync());
        }

        // GET: Insumos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insumos = await _context.Insumos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insumos == null)
            {
                return NotFound();
            }

            return View(insumos);
        }

        // GET: Insumos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insumos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Quantidade,UnidadeMedida")] Insumos insumos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(insumos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insumos);
        }

        // GET: Insumos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insumos = await _context.Insumos.FindAsync(id);
            if (insumos == null)
            {
                return NotFound();
            }
            return View(insumos);
        }

        // POST: Insumos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Quantidade,UnidadeMedida")] Insumos insumos)
        {
            if (id != insumos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insumos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsumosExists(insumos.Id))
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
            return View(insumos);
        }

        // GET: Insumos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insumos = await _context.Insumos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insumos == null)
            {
                return NotFound();
            }

            return View(insumos);
        }

        // POST: Insumos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var insumos = await _context.Insumos.FindAsync(id);
            if (insumos != null)
            {
                _context.Insumos.Remove(insumos);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsumosExists(int id)
        {
            return _context.Insumos.Any(e => e.Id == id);
        }
    }
}
