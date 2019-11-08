using PuntoVentaWeb.Data;
using PuntoVentaWeb.Helpers;
using PuntoVentaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoVentaWeb.SeedData
{
    public class SeedData
    {
        private readonly RepuestosDbContext _repuestosDbContext;
        private readonly IUserHelper _userHelper;
        public SeedData(RepuestosDbContext repuestosDbContext,IUserHelper userHelper)
        {
            _repuestosDbContext = repuestosDbContext;
            _userHelper = userHelper;
        }

        public async Task SeedDatos()
        {
            await _repuestosDbContext.Database.EnsureCreatedAsync(); //verifica que la base esta creada
            await CheckRoles();

            
          var admin=  await CheckUserAsync("Jack", "Roberto", "Delgado", "Gomez", "jroberto55@gmail.com", "02/02/1965", 'M', 'C', "admin");

           
          var v =  await CheckUserAsync("Karen", "craciela", "Caballero", "Espinosa", "ckaren55@gmail.com", "02/02/1965", 'F', 'S', "vendedor");

        }

        private async Task<User> CheckUserAsync(
            string primerNombre,
            string segundoNombre,
            string primerApellido,
            string segundoApellido,
            string email,
            string fechaNac, 
            char sexo,
            char estadoCivil
           ,string role)
        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    PrimerNombre = primerNombre,
                    SegundoNombre = segundoNombre,
                    PrimerApellido = primerApellido,
                    SegundoApellido = segundoApellido,
                    Email = email,
                    UserName = email,
                    FechaNac = fechaNac,
                    Sexo = sexo,
                    EstadoCivil = estadoCivil

                };
                await _userHelper.AddUserAsync(user,"123456");
                await _userHelper.AddUserToRoleAsync(user, role);
                
            }
            return user;
        }

        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("admin");
            await _userHelper.CheckRoleAsync("vendedor");
        }
    }
}
