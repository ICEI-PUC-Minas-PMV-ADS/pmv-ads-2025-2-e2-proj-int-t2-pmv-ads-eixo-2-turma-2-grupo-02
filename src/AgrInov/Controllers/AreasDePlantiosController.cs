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
    public class AreasDePlantiosController : Controller
    {
        private readonly AppDbContext _context;

        public AreasDePlantiosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: AreaDePlantios
        public async Task<IActionResult> Index()
        {
            return View(await _context.AreasDePlantio.ToListAsync());
        }

        // GET: AreaDePlantios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var areaDePlantio = await _context.AreasDePlantio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (areaDePlantio == null)
            {
                return NotFound();
            }

            return View(areaDePlantio);
        }

        // GET: AreaDePlantios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AreaDePlantios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataInicio,DataFimPrevista,AreaUtilizada,Status")] AreaDePlantio areaDePlantio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(areaDePlantio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(areaDePlantio);
        }

        // GET: AreaDePlantios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var areaDePlantio = await _context.AreasDePlantio.FindAsync(id);
            if (areaDePlantio == null)
            {
                return NotFound();
            }
            return View(areaDePlantio);
        }

        // POST: AreaDePlantios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataInicio,DataFimPrevista,AreaUtilizada,Status")] AreaDePlantio areaDePlantio)
        {
            if (id != areaDePlantio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(areaDePlantio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AreaDePlantioExists(areaDePlantio.Id))
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
            return View(areaDePlantio);
        }

        // GET: AreaDePlantios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var areaDePlantio = await _context.AreasDePlantio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (areaDePlantio == null)
            {
                return NotFound();
            }

            return View(areaDePlantio);
        }

        // POST: AreaDePlantios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var areaDePlantio = await _context.AreasDePlantio.FindAsync(id);
            if (areaDePlantio != null)
            {
                _context.AreasDePlantio.Remove(areaDePlantio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AreaDePlantioExists(int id)
        {
            return _context.AreasDePlantio.Any(e => e.Id == id);
        }
    }
}
