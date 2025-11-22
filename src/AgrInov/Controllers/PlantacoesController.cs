using AgrInov.Data;
using AgrInov.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AgrInov.Controllers
{
    public class PlantacoesController : Controller
    {
        private readonly AppDbContext _context;

        public PlantacoesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Plantacoes
        public async Task<IActionResult> Index()
        {
            var plantacoes = await _context.Plantacoes
                .Include(p => p.Cultura)
                .ToListAsync();

            return View(plantacoes);
        }

        // GET: Plantacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plantacao = await _context.Plantacoes
                .Include(p => p.AreaDePlantio)
                .Include(p => p.Cultura)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plantacao == null)
            {
                return NotFound();
            }

            return View(plantacao);
        }

        // GET: Plantacoes/Create
        public IActionResult Create()
        {
            ViewData["AreaDePlantioId"] = new SelectList(_context.AreasDePlantio, "Id", "Nome");
            ViewData["CulturaId"] = new SelectList(_context.Culturas, "Id", "Nome");
            return View();
        }

        // POST: Plantacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AreaDePlantioId,DataInicio,DataFimPrevista,AreaUtilizada,Status,Producao,Saude,CulturaId")] Plantacao plantacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plantacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AreaDePlantioId"] = new SelectList(_context.AreasDePlantio, "Id", "Nome", plantacao.AreaDePlantioId);
            ViewData["CulturaId"] = new SelectList(_context.Culturas, "Id", "Nome", plantacao.CulturaId);
            return View(plantacao);
        }

        // GET: Plantacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plantacao = await _context.Plantacoes
                .Include(p => p.Cultura)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (plantacao == null)
            {
                return NotFound();
            }

            ViewData["AreaDePlantioId"] = new SelectList(_context.AreasDePlantio, "Id", "Nome");
            return View(plantacao);
        }

        // POST: Plantacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AreaDePlantioId,DataInicio,DataFimPrevista,AreaUtilizada,Status,Producao,Saude")] Plantacao plantacao)
        {
            if (id != plantacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var plantacaoExistente = await _context.Plantacoes.FindAsync(id);

                    if (plantacaoExistente == null)
                    {
                        return NotFound();
                    }

                    plantacaoExistente.AreaDePlantioId = plantacao.AreaDePlantioId;
                    plantacaoExistente.DataInicio = plantacao.DataInicio;
                    plantacaoExistente.DataFimPrevista = plantacao.DataFimPrevista;
                    plantacaoExistente.AreaUtilizada = plantacao.AreaUtilizada;
                    plantacaoExistente.Status = plantacao.Status;
                    plantacaoExistente.Producao = plantacao.Producao;
                    plantacaoExistente.Saude = plantacao.Saude;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlantacaoExists(plantacao.Id))
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
            return View(plantacao);
        }

        // GET: Plantacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plantacao = await _context.Plantacoes
                .Include(p => p.AreaDePlantio)
                .Include(p => p.Cultura)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plantacao == null)
            {
                return NotFound();
            }

            return View(plantacao);
        }

        // POST: Plantacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plantacao = await _context.Plantacoes.FindAsync(id);
            if (plantacao != null)
            {
                _context.Plantacoes.Remove(plantacao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlantacaoExists(int id)
        {
            return _context.Plantacoes.Any(e => e.Id == id);
        }
    }
}
