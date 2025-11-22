using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AgrInov.Models
{
public class RelatorioSafraPageViewModel
{
    public int? CulturaSelecionadaId { get; set; }
    public List<Cultura> Culturas { get; set; } = new();

    public List<SafraProducaoItem> Resultados { get; set; } = new();
}

public class SafraProducaoItem
{
    public int Ano { get; set; }
    public int Producao { get; set; }
}

}
