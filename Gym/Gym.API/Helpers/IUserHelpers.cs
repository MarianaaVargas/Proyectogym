using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Gym.API.Data;
using Gym.Shared.Entities;
using Gym.Shared.Entidades;

namespace Market.API.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly DataContext _context;
        private readonly UserManager<Usuarios> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserHelper(DataContext context, UserManager<Usuarios> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityResult> AddUserAsync(Usuarios user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task AddUserToRoleAsync(Usuarios user, string roleName)
        {
            await _userManager.AddToRoleAsync(user, roleName);
        }

        public async Task CheckRoleAsync(string roleName)
        {
            bool roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName
                });
            }
        }

        public async Task<Usuarios> GetUserAsync(string email)
        {
            return await _context.usuarios
                .Include(u => u.Id_Usuario)
                .FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<bool> IsUserInRoleAsync(Usuarios user, string roleName)
        {
            return await _userManager.IsInRoleAsync(user, roleName);
        }
    }
}
