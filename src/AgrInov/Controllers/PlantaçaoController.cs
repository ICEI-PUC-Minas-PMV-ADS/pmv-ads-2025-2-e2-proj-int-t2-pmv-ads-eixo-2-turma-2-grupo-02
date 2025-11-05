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
    public class PlantaçaoController : Controller
    {
        private readonly AppDbContext _context;

        public PlantaçaoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Plantaçao
        public async Task<IActionResult> Index()
        {
            return View(await _context.Plantações.ToListAsync());
        }

        // GET: Plantaçao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plantaçao = await _context.Plantações
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plantaçao == null)
            {
                return NotFound();
            }

            return View(plantaçao);
        }

        // GET: Plantaçao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Plantaçao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataInicio,DataFimPrevista,AreaUtilizada,Status,Producao,Saude")] Plantacao plantaçao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plantaçao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plantaçao);
        }

        // GET: Plantaçao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plantaçao = await _context.Plantações.FindAsync(id);
            if (plantaçao == null)
            {
                return NotFound();
            }
            return View(plantaçao);
        }

        // POST: Plantaçao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataInicio,DataFimPrevista,AreaUtilizada,Status,Producao,Saude")] Plantacao plantaçao)
        {
            if (id != plantaçao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plantaçao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlantaçaoExists(plantaçao.Id))
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
            return View(plantaçao);
        }

        // GET: Plantaçao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plantaçao = await _context.Plantações
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plantaçao == null)
            {
                return NotFound();
            }

            return View(plantaçao);
        }

        // POST: Plantaçao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plantaçao = await _context.Plantações.FindAsync(id);
            if (plantaçao != null)
            {
                _context.Plantações.Remove(plantaçao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlantaçaoExists(int id)
        {
            return _context.Plantações.Any(e => e.Id == id);
        }
    }
}
