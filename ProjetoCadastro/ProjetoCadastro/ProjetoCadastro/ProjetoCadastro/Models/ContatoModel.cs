using System.ComponentModel.DataAnnotations;

namespace ProjetoCadastro.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome � obrigat�rio.")]
        [StringLength(100, ErrorMessage = "O nome n�o pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF � obrigat�rio.")]
        [StringLength(14, ErrorMessage = "O CPF deve ter 14 caracteres.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O telefone � obrigat�rio.")]
        [StringLength(15, ErrorMessage = "O telefone n�o pode exceder 15 caracteres.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O tipo de telefone � obrigat�rio.")]
        public string TelefoneTipo { get; set; }
    }
}
