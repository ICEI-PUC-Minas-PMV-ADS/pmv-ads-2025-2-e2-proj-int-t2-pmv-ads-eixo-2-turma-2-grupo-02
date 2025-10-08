using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgrInov.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public string Matricula { get; set; }

        public string Cpf { get; set; }

        public int CargoId { get; set; }

        [ForeignKey("CargoId")]
        [Required(ErrorMessage = "Obrigatório informar o cargo")]
        public Cargo Cargo { get; set; }


    }
}
