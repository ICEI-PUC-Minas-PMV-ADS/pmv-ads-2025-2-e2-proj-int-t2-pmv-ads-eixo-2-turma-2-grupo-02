using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("PropriedadeAgricula")]
    public class PropriedadeAgricula
    {
        [Key]
        public int Id { get; set; }
        public float Area { get; set; }
        public float TamanhoHectares { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o CNPJ")]
        public string Cnpj { get; set; }
        public string Status { get; set; }
        public string TipoDeSolo { get; set; }
        public string Localizacao { get; set; }

    }
}
