using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("AreaDePlantio")]
    public class AreaDePlantio
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFimPrevista { get; set; }
        public float AreaUtilizada { get; set; }
        public string Status { get; set; }

    }
}
