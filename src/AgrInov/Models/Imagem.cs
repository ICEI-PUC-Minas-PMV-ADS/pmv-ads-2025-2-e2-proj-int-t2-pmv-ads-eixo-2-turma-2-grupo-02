using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("Imagem")]
    public class Imagem
    {
        [Key]
        public int Id { get; set; }
        
        [DisplayName("Imagem")]
        public string imagem { get; set; }
        
        [DisplayName("Latitude")]
        public float Latitude { get; set; }

       [DisplayName("Longitude")]
        public float Longitude { get; set; }

        [DisplayName("Data Criação")]
        public string dataCriacao { get; set; }

    }
}
