using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using AgrInov.Data;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using System.IO;
using AgrInov.Models;
using AgrInov.Utils;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System.Drawing;


namespace AgrInov.Controllers
{
    
    public class SafraController : Controller
{
    private readonly AppDbContext _context;

    public SafraController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(int? culturaId)
    {
        var vm = new RelatorioSafraPageViewModel
        {
            CulturaSelecionadaId = culturaId,
            Culturas = await _context.Culturas.OrderBy(c => c.Nome).ToListAsync()
        };

        // Se nenhuma cultura foi escolhida, retornar somente a lista
        if (culturaId == null)
            return View(vm);

        // Buscar e agrupar produções da cultura escolhida
        vm.Resultados = await _context.Plantacoes
            .Where(p => p.CulturaId == culturaId)
            .GroupBy(p => p.DataInicio.Year)
            .OrderBy(g => g.Key)
            .Select(g => new SafraProducaoItem
            {
                Ano = g.Key,
                Producao = g.Sum(x => x.Producao)
            })
            .ToListAsync();

        return View(vm);
    }
}

}

