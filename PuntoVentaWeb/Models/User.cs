using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PuntoVentaWeb.Models
{
    public class User : IdentityUser
    {
        [Display(Name ="Primer Nombre")]
        [Required(ErrorMessage = "campo requerido")]
        public string PrimerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]
        [Required(ErrorMessage = "campo requerido")]
        public string SegundoNombre { get; set; }

        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "campo requerido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        [Required(ErrorMessage = "campo requerido")]
        public string SegundoApellido { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "campo requerido")]
        public string FechaNac { get; set; }

        [Display(Name = "Sexo")]
        [MaxLength(1, ErrorMessage = "campo {0} no puede ser mayor que {1}")]
        [Required(ErrorMessage = "campo requerido")]
        public char Sexo { get; set; }

        [Display(Name = "Estado Civil")]
        [MaxLength(1,ErrorMessage ="campo {0} no puede ser mayor que {1}")]
        [Required(ErrorMessage = "campo requerido")]
        public char EstadoCivil { get; set; }
    }
}
