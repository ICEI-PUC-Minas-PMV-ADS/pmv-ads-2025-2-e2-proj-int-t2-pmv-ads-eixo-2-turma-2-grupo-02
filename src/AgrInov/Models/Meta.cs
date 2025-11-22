using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("Metas")]
    public class Meta
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Data de início")]
        public DateTime DataInicio { get; set; }

        [DisplayName("Data final")]
        public DateTime DataFim { get; set; }

        [DisplayName("Quantidade (kg)")]
        public int Quantidade { get; set; }

        [DisplayName("Cultura")]
        public int CulturaId { get; set; }

        [ForeignKey("CulturaId")]
        public Cultura Cultura { get; set; }
    }
}
