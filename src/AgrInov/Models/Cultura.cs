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

        [Required(ErrorMessage = "Obrigatório informar uma boa prática de plantio!")]
        [Display(Name = "Boas práticas")]
        public string Recomendacao{ get; set; }

        [Required(ErrorMessage = "Obrigatório informar uma recomendação de rotação de cultura!")]
        [Display(Name = "Recomendação de rotação")]
        public string Rotacao { get; set; }

        public ICollection<Venda> Vendas { get; set; }
        public ICollection<Meta> Metas { get; set; }
    }
}
