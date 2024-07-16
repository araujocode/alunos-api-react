using System.ComponentModel.DataAnnotations;

namespace AlunosApi.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória")]
        [StringLength(20, ErrorMessage = "A {0} deve ter no mínimo {2} e no máximo {1} caracteres", MinimumLength = 10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
