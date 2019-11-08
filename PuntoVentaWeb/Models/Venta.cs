using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoVentaWeb.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public string NRODOC { get; set; }
        public string NRO_CF { get; set; }
        [Display(Name ="Fecha de venta")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}",ApplyFormatInEditMode =true)]
        public DateTime FECHAVENTA { get; set; }

        public decimal SUBTOTAL { get; set; }
        public decimal DESCUENTO { get; set; }

        public decimal IVA { get; set; }

        public decimal MONTOTOTAL { get; set; }

        public User User { get; set; }
        public Cliente Cliente { get; set; }

        public TipoDocumento TipoDocumento { get; set; }

        [Display(Name = "Fecha de venta")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaVentaLocal => FECHAVENTA.ToLocalTime();
    }
}
