using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoVentaWeb.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="el campo  es requerido")]
        [EmailAddress(ErrorMessage="ingresa un correo valido")]
        public string userName { get; set; }
        [Required(ErrorMessage ="el campo es requerido")]
        [MaxLength(6)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
