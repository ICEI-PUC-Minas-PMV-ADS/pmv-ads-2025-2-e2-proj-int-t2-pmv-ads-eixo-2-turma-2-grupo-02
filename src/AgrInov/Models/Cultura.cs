using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("Culturas")]
    public class Cultura
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        public ICollection<Venda> Vendas { get; set; }
    }
}
