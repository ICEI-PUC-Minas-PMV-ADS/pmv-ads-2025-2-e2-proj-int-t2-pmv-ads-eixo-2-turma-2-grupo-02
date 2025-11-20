using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgrInov.Data;
using AgrInov.Models; // Importante para achar o WeatherModels
using System.Net.Http; // Importante para API
using System.Text.Json; // Importante para ler o JSON
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
                    // Trata acentos e espaços (ex: "São Paulo" vira código seguro)
                    string cidadeCodificada = Uri.EscapeDataString(cidade);

                    // SUA CHAVE DA HG BRASIL
                    string apiKey = Environment.GetEnvironmentVariable("HGBRASIL_APIKEY");
                    string url = $"https://api.hgbrasil.com/weather?key={apiKey}&city_name={cidadeCodificada}&format=json-cors";

                    using (var httpClient = new HttpClient())
                    {
                        var response = await httpClient.GetAsync(url);
                        if (response.IsSuccessStatusCode)
                        {
                            string json = await response.Content.ReadAsStringAsync();
                            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                            var dados = JsonSerializer.Deserialize<AgrInov.Models.PrevisaoRaiz>(json, options);

                            if (dados?.results?.forecast != null)
                            {
                                ViewBag.PrevisaoDoTempo = dados.results.forecast.Take(5).ToList();
                                ViewBag.CidadeClima = dados.results.city_name;
                            }
                        }
                    }
                }
            }
            catch (Exception) { /* Ignora erros de conexão/API */ }

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
                // CORREÇÃO 1: Força ID = 0 para evitar erro de Identity Insert
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
        [HttpPost]
        public async Task<IActionResult> Edit(int id, PropriedadeAgricula propriedade)
        {
            if (id != propriedade.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    // CORREÇÃO 2: Busca o original e atualiza os valores
                    // Isso IMPEDE que o sistema crie uma cópia duplicada
                    var propriedadeNoBanco = await _context.PropriedadeAgricula.FindAsync(id);

                    if (propriedadeNoBanco == null) return NotFound();

                    // Copia os dados novos para o registro antigo
                    _context.Entry(propriedadeNoBanco).CurrentValues.SetValues(propriedade);

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