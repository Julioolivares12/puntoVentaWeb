using Microsoft.AspNetCore.Identity;
using PuntoVentaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuntoVentaWeb.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);
        Task<IdentityResult> AddUserAsync(User user,string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user,string roleName);
        Task<bool> IsUserInRoleAsync(User user,string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel loginView);

        Task LogoutAsync();

        Task<bool> DeleteUserAsync(string email);

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<SignInResult> ValidatePasswordAsync(User user, string password);

        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);

        Task<IdentityResult> ConfirmEmailAsync(User user, string token);

        Task<string> GenerateEmailConfirmationTokenAsync(User user);

        Task<User> GetUserByIdAsync(string userId);

        Task<string> GeneratePasswordResetTokenAsync(User user);

        Task<IdentityResult> ResetPasswordAsync(User user, string token, string password);
    }
}
