using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("Cargos")]
    public class Cargo
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        public string Descricao { get; set; }
    }
}
