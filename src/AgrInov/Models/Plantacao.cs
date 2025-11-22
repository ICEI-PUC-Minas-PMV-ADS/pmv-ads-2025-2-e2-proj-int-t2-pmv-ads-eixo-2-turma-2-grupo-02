using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("Plantacoes")]
    public class Plantacao
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Data de ínicio")]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Data de termino")]
        public DateTime DataFimPrevista { get; set; }

        [Display(Name = "Data de utilizada")]
        public float AreaUtilizada { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        [Display(Name = "Produção")]
        public int Producao { get; set; }

        [Display(Name = "Saúde")]
        public string Saude { get; set; }

        [Display(Name = "Área de plantio")]
        public int? AreaDePlantioId { get; set; }

        [Display(Name = "Cultura")]
        public int? CulturaId { get; set; }

        [ForeignKey("AreaDePlantioId")]
        public AreaDePlantio AreaDePlantio { get; set; }

        [ForeignKey("CulturaId")]
        public Cultura Cultura { get; set; }

    }
}
