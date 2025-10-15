using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("Insumos")]
    public class Insumo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Quantidade { get; set; }
        [DisplayName("Unidade Medida")]
        public string UnidadeMedida { get; set; }
    }
}
