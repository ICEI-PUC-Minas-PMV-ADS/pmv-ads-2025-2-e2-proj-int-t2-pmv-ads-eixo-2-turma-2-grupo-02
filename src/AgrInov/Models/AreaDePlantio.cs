using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("AreasDePlantio")]
    [Display(Name = "Áreas de Plantio")]
    public class AreaDePlantio
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Data de ínicio")]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data de termino")]
        public DateTime DataFimPrevista { get; set; }
        [Display(Name = "Área utilizada")]
        public float AreaUtilizada { get; set; }
        public string Status { get; set; }

        public ICollection<Plantacao> Plantacoes { get; set; }
    }
}
