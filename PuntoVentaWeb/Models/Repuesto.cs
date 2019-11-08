using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoVentaWeb.Models
{
    public class Repuesto
    {
        public int Id { get; set; }
        public string Nombe { get; set; }
        public string Descripcion { get; set; }
        [Display(Name ="Precio de compra")]
        public double PrecioCompra { get; set; }
        [Display(Name ="Precio De Venta")]
        public double PrecioVenta { get; set; }
        public double Descuento { get; set; }
        [Display(Name ="Numero de Motor")]
        public int NumMotor { get; set; }
        [Display(Name ="Numero Chasis")]
        public int NumChasis { get; set; }
        [Display(Name ="Numero de Vin")]
        public int NumVin { get; set; }
        public string UPC { get; set; }
        public decimal Cantidad { get; set; }

        public ParteVehiculo ParteVehiculo { get; set; }

        public MarcaVehiculo MarcaVehiculo { get; set; }
    }
}
