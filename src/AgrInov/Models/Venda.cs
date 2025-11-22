using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("Vendas")]
    public class Venda
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar um valor!")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quantidade em Kg!")]
        [Display(Name = "Quantidade(Kg)")]
        public int Quantidade { get; set; }

        [Display(Name = "Cultura")]
        [Required(ErrorMessage = "Obrigatório informar uma cultura!")]
        public int CulturaId { get; set; }

        [ForeignKey("CulturaId")]
        public Cultura Cultura { get; set; }

        [DisplayName("Data da Operação")]
        public DateTime DataOperacao { get; set; } = DateTime.Now;
    }
}
