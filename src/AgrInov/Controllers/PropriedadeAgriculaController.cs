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
    }


}
