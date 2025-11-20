using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgrInov.Data;
using AgrInov.Models;
using System.Net.Http;
using System.Text.Json;

namespace AgrInov.Controllers
{
    public class PropriedadeAgriculaController(AppDbContext context) : Controller
    {
        private readonly AppDbContext _context = context;
        // Cache da configuração do JsonSerializerOptions
        private static readonly JsonSerializerOptions _jsonOptions = new() { PropertyNameCaseInsensitive = true };

        // GET: PropriedadeAgricula/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var propriedadeAgricula = await _context.PropriedadeAgricula
                .FirstOrDefaultAsync(m => m.Id == id);

            if (propriedadeAgricula == null) return NotFound();

            // --- LÓGICA DO CLIMA ---
            ViewBag.PrevisaoDoTempo = new List<AgrInov.Models.PrevisaoDiaria>();
            ViewBag.CidadeClima = "Localização Desconhecida";

            try
            {
                if (!string.IsNullOrEmpty(propriedadeAgricula.Localizacao))
                {
                    string cidade = propriedadeAgricula.Localizacao;
                    string cidadeCodificada = Uri.EscapeDataString(cidade);
                    string apiKey = "69343337";
                    string url = $"https://api.hgbrasil.com/weather?key={apiKey}&city_name={cidadeCodificada}&format=json-cors";

                    using var httpClient = new HttpClient();
                    var response = await httpClient.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        // Usa a instância cacheada de JsonSerializerOptions
                        var dados = JsonSerializer.Deserialize<AgrInov.Models.PrevisaoRaiz>(json, _jsonOptions);

                        if (dados?.results?.forecast != null)
                        {
                            ViewBag.PrevisaoDoTempo = dados.results.forecast.Take(5).ToList();
                            ViewBag.CidadeClima = dados.results.city_name;
                        }
                    }
                }
            }
            catch (Exception) { /* Ignora erros de API */ }

            return View(propriedadeAgricula);
        }

        // GET: PropriedadeAgricula
        public async Task<IActionResult> Index()
        {
            return View(await _context.PropriedadeAgricula.ToListAsync());
        }

        // GET: PropriedadeAgricula/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PropriedadeAgricula/Create
        [HttpPost]
        public async Task<IActionResult> Create(PropriedadeAgricula propriedade)
        {
            if (ModelState.IsValid)
            {
                // Garante que é um NOVO registro zerando o ID
                propriedade.Id = 0;
                _context.PropriedadeAgricula.Add(propriedade);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(propriedade);
        }

        // GET: PropriedadeAgricula/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var propriedade = await _context.PropriedadeAgricula.FindAsync(id);
            if (propriedade == null) return NotFound();

            return View(propriedade);
        }

        // POST: PropriedadeAgricula/Edit/5
        // AQUI ESTÁ A MÁGICA PARA NÃO DUPLICAR
        [HttpPost]
        public async Task<IActionResult> Edit(int id, PropriedadeAgricula propriedade)
        {
            if (id != propriedade.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    // 1. Busca o item REAL no banco
                    var propriedadeNoBanco = await _context.PropriedadeAgricula.FindAsync(id);

                    if (propriedadeNoBanco == null) return NotFound();

                    // 2. Copia os valores do formulário para o item do banco
                    // Isso atualiza APENAS o que mudou, mantendo o mesmo ID
                    _context.Entry(propriedadeNoBanco).CurrentValues.SetValues(propriedade);

                    // 3. Salva
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropriedadeExists(propriedade.Id)) return NotFound();
                    else throw;
                }
            }
            return View(propriedade);
        }

        // GET: PropriedadeAgricula/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var propriedade = await _context.PropriedadeAgricula.FindAsync(id);
            if (propriedade == null) return NotFound();

            return View(propriedade);
        }

        // POST: PropriedadeAgricula/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null) return NotFound();

            var propriedade = await _context.PropriedadeAgricula.FindAsync(id);
            if (propriedade != null)
            {
                _context.PropriedadeAgricula.Remove(propriedade);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropriedadeExists(int id)
        {
            return _context.PropriedadeAgricula.Any(e => e.Id == id);
        }
    }
}