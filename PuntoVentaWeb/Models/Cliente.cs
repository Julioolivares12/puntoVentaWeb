using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoVentaWeb.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Display(Name = "Primer Nombre")]
        [Required(ErrorMessage = "campo requerido")]
        public string PRIMERNOMBRE { get; set; }
        [Display(Name = "Segundo Nombre")]
        [Required(ErrorMessage = "campo requerido")]
        public string SEGUNDONOMBRE { get; set; }
        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "campo requerido")]
        public string PRIMERAPELLIDO { get; set; }
        [Display(Name = "Segundo Apellido")]
        [Required(ErrorMessage = "campo requerido")]
        public string SEGUNDOAPELLIDO { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "campo requerido")]
        public string FECHANAC { get; set; }
        [Display(Name = "Sexo")]
        [MaxLength(1, ErrorMessage = "campo {0} no puede ser mayor que {1}")]
        [Required(ErrorMessage = "campo requerido")]
        public string SEXO { get; set; }
        [Display(Name = "Estado Civil")]
        [MaxLength(1, ErrorMessage = "campo {0} no puede ser mayor que {1}")]
        [Required(ErrorMessage = "campo requerido")]
        public string ESTADO_CIVIL { get; set; }
        [Display(Name ="Lugar de trabajo")]
        public string LUGARTRABAJO { get; set; }
    }
}
