using AgrInov.Data;
using AgrInov.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgrInov.Controllers
{
    public class RelatorioDeMetasController : Controller
    {
        private readonly AppDbContext _context;

        public RelatorioDeMetasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var anosMetas = await _context.Meta
                .Select(m => m.DataFim.Year)
                .Distinct()
                .ToListAsync();

            var anosPlantacoes = await _context.Plantacoes
                .Where(p => p.Status != "Cancelada")
                .Select(p => p.DataFimPrevista.Year)
                .Distinct()
                .ToListAsync();

            var anos = anosMetas.Union(anosPlantacoes)
                .OrderByDescending(a => a)
                .ToList();

            var relatorios = new List<RelatorioMetasViewModel>();

            foreach (var ano in anos)
            {
                var metasAno = await _context.Meta
                    .Include(m => m.Cultura)
                    .Where(m => m.DataFim.Year == ano)
                    .ToListAsync();

                var plantacoesAno = await _context.Plantacoes
                    .Include(p => p.Cultura)
                    .Where(p => p.DataFimPrevista.Year == ano && p.CulturaId.HasValue && p.Status != "Cancelada")
                    .ToListAsync();

                var metasPorCultura = metasAno
                    .GroupBy(m => new { m.CulturaId, m.Cultura.Nome })
                    .Select(g => new
                    {
                        CulturaId = (int?)g.Key.CulturaId,
                        NomeCultura = g.Key.Nome,
                        QuantidadeTotal = g.Sum(m => m.Quantidade)
                    })
                    .ToList();

                var producaoPorCultura = plantacoesAno
                    .GroupBy(p => new { p.CulturaId, p.Cultura.Nome })
                    .Select(g => new
                    {
                        CulturaId = g.Key.CulturaId,
                        NomeCultura = g.Key.Nome,
                        ProducaoTotal = g.Sum(p => p.Producao)
                    })
                    .ToList();

                var todasCulturas = metasPorCultura
                    .Select(m => new { m.CulturaId, m.NomeCultura })
                    .Union(producaoPorCultura.Select(p => new { p.CulturaId, p.NomeCultura }))
                    .Distinct()
                    .ToList();

                var comparacoes = new List<ComparacaoMetaProducao>();

                foreach (var cultura in todasCulturas)
                {
                    var meta = metasPorCultura.FirstOrDefault(m => m.CulturaId == cultura.CulturaId);
                    var producao = producaoPorCultura.FirstOrDefault(p => p.CulturaId == cultura.CulturaId);

                    comparacoes.Add(new ComparacaoMetaProducao
                    {
                        NomeCultura = cultura.NomeCultura,
                        QuantidadeMeta = meta?.QuantidadeTotal ?? 0,
                        ProducaoReal = producao?.ProducaoTotal ?? 0
                    });
                }

                relatorios.Add(new RelatorioMetasViewModel
                {
                    Ano = ano,
                    Comparacoes = comparacoes.OrderBy(c => c.NomeCultura).ToList()
                });
            }

            return View(relatorios);
        }
    }
}
