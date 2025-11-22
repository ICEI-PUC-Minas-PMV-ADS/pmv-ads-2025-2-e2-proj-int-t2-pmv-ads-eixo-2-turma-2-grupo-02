using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace AgrInov.Models
{
    [Table("ImagemPropriedade")]
    [PrimaryKey(nameof(PropriedadeAgriculaId), nameof(ImagemId))]
    public class ImagemPropriedade
    {
        
        public int? PropriedadeAgriculaId { get; set; }

        public int ImagemId { get; set; } 
    }
}
