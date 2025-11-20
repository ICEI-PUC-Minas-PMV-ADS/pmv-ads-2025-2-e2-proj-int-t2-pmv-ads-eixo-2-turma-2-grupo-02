using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("PropriedadeAgricula")]
    public class PropriedadeAgricula
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Área")]
        public float Area { get; set; }
        
        [DisplayName("Hectares")]
        public float TamanhoHectares { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o CNPJ")]
        public string Cnpj { get; set; }
        public string Status { get; set; }

        [DisplayName("Tipo de Solo")]
        public string TipoDeSolo { get; set; }

        [DisplayName("Localização")]
        public string Localizacao { get; set; }

        public ICollection<ImagemPropriedade> ImagemPropriedade  { get; set; }
    }
}
