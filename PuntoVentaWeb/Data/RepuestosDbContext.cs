using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PuntoVentaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoVentaWeb.Data
{
    public class RepuestosDbContext : IdentityDbContext<User>
    {
        public RepuestosDbContext(DbContextOptions<RepuestosDbContext> options) : base(options)
        {

        }
        //aqui agregar las tablas de la bd
        //public DbSet<User> Users { get; set; }
        public DbSet<ParteVehiculo> ParteVehiculos { get; set; }

        public DbSet<MarcaVehiculo> MarcaVehiculos { get; set; }

        public DbSet<Repuesto> Repuestos { get; set; }
       

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<TipoDocumento> TipoDocumentos { get; set; }

        public DbSet<Venta> Ventas { get; set; }

        public DbSet<DetalleVenta> DetalleVentas { get; set; }

        public DbSet<MetodosDar> MetodosDars { get; set; }

        public DbSet<MetodoTomar> MetodoTomars { get; set; }


    }
}
