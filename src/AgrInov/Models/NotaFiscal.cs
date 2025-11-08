using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgrInov.Models
{
    public class NotaFiscal
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a chave!")]
        public string Chave { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a nfe!")]
        public string Nfe { get; set; }

        [DisplayName("Data da Operação")]
        public DateTime DataOperacao { get; set; } = DateTime.Now;
    }
}
