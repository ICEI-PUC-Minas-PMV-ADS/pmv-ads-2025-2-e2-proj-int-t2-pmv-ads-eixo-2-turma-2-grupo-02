using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("Plantacoes")]
    public class Plantacao
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFimPrevista { get; set; }
        public float AreaUtilizada { get; set; }
        public string Status { get; set; }
        public int Producao { get; set; }
        public string Saude  { get; set; }
        [Display(Name = "Cultura")]
        public int? CulturaId { get; set; }

        [ForeignKey("CulturaId")]
        public Cultura Cultura { get; set; }

    }
}
