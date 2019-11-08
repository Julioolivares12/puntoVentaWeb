using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PuntoVentaWeb.Helpers;
using PuntoVentaWeb.Models;

namespace PuntoVentaWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IUserHelper _userHelper;
        public LoginController(ILogger<LoginController> logger,IUserHelper userHelper)
        {
            _logger = logger;
            _userHelper = userHelper;
        }

        public async Task<IActionResult> Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                //obtengo el usuario
                var u = await  _userHelper.GetUserByEmailAsync(User.Identity.Name);
                //verifico el rol del usuario
                if (await _userHelper.IsUserInRoleAsync(u, "SuperAdmin"))
                {
                    return RedirectToAction("", "");
                }
                else
                {
                    return RedirectToAction("index", "Venta");
                }
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var r = await _userHelper.LoginAsync(viewModel);
                if (r.Succeeded)
                {
                    var u = await _userHelper.GetUserByEmailAsync(viewModel.userName);
                    if (u!= null)
                    {
                        if (await _userHelper.IsUserInRoleAsync(u, "admin"))
                        {
                           return RedirectToAction("", "");
                        }
                        else
                        {
                            return RedirectToAction("index","Venta");
                        }
                                
                    }
                }
            }
            //ModelState.AddModelError(String.Empty, "correo o contraseña invalidos");
            return View(viewModel);
        }
        public async Task<IActionResult> Logout()
        {
            await _userHelper.LogoutAsync();
            return RedirectToAction("Login", "login");
        }

    }
}
