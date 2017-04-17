using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UsuarioModel
    {
        [Required(ErrorMessage = "Se necesita ingresar correo")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Correo")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Se necesita ingresar una contraseña")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
    }
}