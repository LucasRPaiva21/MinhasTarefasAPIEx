using System.ComponentModel.DataAnnotations;

namespace MinhasTarefas.Models
{
    public class UsuarioDTO
    {
        [Required]
        public string Nome { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Compare("Senha")]
        [Required]
        public string ConfirmacaoSenha { get; set; }

    }
}
