using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AgrInov.Models
{
    public class ImagemPropriedadeViewModel
    {
        public Imagem Imagem { get; set; }
        public PropriedadeAgricula PropriedadeAgricula { get; set; }

        public IEnumerable<PropriedadeAgricula> ListPropriedadeAgricula { get; set; }

    }
}
