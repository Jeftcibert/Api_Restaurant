using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApiBD_Restaurante.Entidades
{
    public class Login
    {
        [Display(Name = "Nombre de usuario")]
        public string? nombreUsuario { get; set; }

        [Display(Name = "Constraseña")]
        public string? clave { get; set; }

    }
}
