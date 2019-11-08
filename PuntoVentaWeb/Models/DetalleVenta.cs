using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PuntoVentaWeb.Models
{
    public class DetalleVenta
    {
        public int Id { get; set; }

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; } 
        public decimal SubTotalRepuesto { get; set; }
        public decimal Descuento { get; set; }
        public decimal IVA { get; set; }

        public decimal TotalRepuesto { get; set; }

        public Venta Venta { get; set; }

        public ICollection<Repuesto> Repuestos { get; set; }

    }
}
