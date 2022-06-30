using System.ComponentModel.DataAnnotations;

namespace curso.api.Models.Usuarios
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "O Login é obrigatorio")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A Senha é obrigatorio")]
        public string Senha { get; set; }
    }
}
