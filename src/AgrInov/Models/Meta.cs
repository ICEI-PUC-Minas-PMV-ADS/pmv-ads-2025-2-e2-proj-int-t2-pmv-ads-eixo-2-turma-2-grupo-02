using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("Metas")]
    public class Meta
    {
        public int Id { get; set; }

        [DisplayName("Data de início")]
        public DateTime DataInicio { get; set; }

        [DisplayName("Data final")]
        public DateTime DataFim { get; set; }

        public int Quantidade { get; set; }

        [DisplayName("Cultura")]
        public int CulturaId { get; set; }

        [ForeignKey("CulturaId")]
        public Cultura Cultura { get; set; }
    }
}
