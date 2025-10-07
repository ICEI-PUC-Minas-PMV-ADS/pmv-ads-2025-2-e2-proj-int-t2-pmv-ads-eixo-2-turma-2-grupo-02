using AgrInov.Data;
using AgrInov.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgrInov.Controllers
{
    public class CulturasController : Controller
    {

        private readonly AppDbContext _context;

        public CulturasController(AppDbContext _context)
        {
            this._context = _context;
        }

        public async Task<IActionResult> Index()
        {
            var culturas = await _context.Culturas.ToListAsync();
            return View(culturas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cultura cultura)
        {
            if(!ModelState.IsValid)
            {
                return View(cultura);
            }

            _context.Culturas.Add(cultura);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var dados = await _context.Culturas.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Cultura cultura)
        {
            if (id != cultura.Id)
            {
                return NotFound(); ;
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Culturas.Update(cultura);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id) {
            if (id == null)
            {
                return NotFound();
            }

            var dados =  await _context.Culturas.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await _context.Culturas.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await _context.Culturas.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }

            _context.Culturas.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
