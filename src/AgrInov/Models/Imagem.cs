using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("Imagens")]
    public class Imagem
    {
        [Key]
       public int Id { get; set; }

        
        [Required]
        [Display(Name = "Imagem")]
        [NotMapped] 
        public IFormFile Image { get; set; }

        [Display(Name = "URL da imagem")]
        public string ImageUrl { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }       
        public DateTime DataCriacao { get; set; }
    }
}
