using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("Insumos")]
    public class Insumo
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Quantidade { get; set; }
        [DisplayName("Unidade Medida")]
        public string UnidadeMedida { get; set; }
        public float Utilizado { get; set; }
        public float Custo { get; set; }

        [DisplayName("Cultura")]
        public int? CulturaId { get; set; }

        [ForeignKey("CulturaId")]
        public Cultura? Cultura { get; set; }
    }
}
