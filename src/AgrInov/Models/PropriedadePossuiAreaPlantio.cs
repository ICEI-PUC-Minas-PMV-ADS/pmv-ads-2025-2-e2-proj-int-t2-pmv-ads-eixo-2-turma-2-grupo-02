using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("PropriedadePossuiAreaPlantio")]
    public class PropriedadePossuiAreaPlantio
    {
        [Key]
        [ForeignKey("PropriedadeAgriculaId")]

        public int? PropriedadeAgriculaId { get; set; }

        [Key]
        [ForeignKey("AreaAgriculaId")]

        public int AreaAgriculaId { get; set; }
        

  
    }
}
