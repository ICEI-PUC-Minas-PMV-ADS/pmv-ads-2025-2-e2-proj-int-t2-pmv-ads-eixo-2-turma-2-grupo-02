using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("Imagens")]
    public class Imagem
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Image { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}
