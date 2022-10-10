using System.ComponentModel.DataAnnotations;

namespace Familia.Models
{
    public class Login
    {
        
        [Key]
        public int IdLogin { get; set; }
        [Required(ErrorMessage = "Debe ingresar un usuario.")]
        public string? Usuario { get; set; }
        [StringLength(15, MinimumLength = 8, ErrorMessage = "La contraseña debe tener entre 8 y 15 caracteres")]
        [Required(ErrorMessage = "Debe ingresar una contraseña.")]
        public string? Contrasena { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un rol.")]
        
        public string? Rol { get; set; }
    }
}
