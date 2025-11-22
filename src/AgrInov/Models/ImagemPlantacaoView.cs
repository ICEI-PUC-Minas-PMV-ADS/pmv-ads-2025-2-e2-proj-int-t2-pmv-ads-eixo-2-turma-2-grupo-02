using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AgrInov.Models
{
    public class ImagemPlantacaoViewModel
    {
        public Imagem Imagem { get; set; }
        public Plantacao Plantacao { get; set; }

        public IEnumerable<Plantacao> ListaPlantacoes { get; set; }
    }
}
