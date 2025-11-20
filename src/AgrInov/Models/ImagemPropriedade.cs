using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace AgrInov.Models
{
    [Table("ImagemPropriedade")]
    [PrimaryKey(nameof(PropriedadeId), nameof(ImagemId))]
    public class ImagemPropriedade
    {
        
        public int? PropriedadeId { get; set; }

        public int ImagemId { get; set; } 
    }
}
