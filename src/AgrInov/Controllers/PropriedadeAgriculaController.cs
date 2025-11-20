using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgrInov.Data;
using AgrInov.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace AgrInov.Controllers
{
    public class PropriedadeAgriculaController : Controller
    {
        private readonly AppDbContext _context;

        public PropriedadeAgriculaController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.PropriedadeAgricula.ToListAsync());
        }

        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PropriedadeAgricula propriedade)
        {
            if (ModelState.IsValid)
            {
                _context.PropriedadeAgricula.Add(propriedade);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(propriedade);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var propriedade = await _context.PropriedadeAgricula.FindAsync(id);

            if (propriedade == null)
                return NotFound();


            return View(propriedade);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, PropriedadeAgricula propriedade)
        {
            if (id != propriedade.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.PropriedadeAgricula.Update(propriedade);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View(propriedade);

        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return null;

            var propriedade = await _context.PropriedadeAgricula.FindAsync(id);

            if (propriedade == null)
                return null;
            return View(propriedade);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propriedade = await _context.PropriedadeAgricula.FindAsync(id);

            if (propriedade == null)
            {
                return NotFound();
            }

            return View(propriedade);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {

            if (id == null)
                return NotFound();

            var pripriedade = await _context.PropriedadeAgricula.FindAsync(id);
            if (pripriedade != null)
            {
                _context.PropriedadeAgricula.Remove(pripriedade);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }

}
