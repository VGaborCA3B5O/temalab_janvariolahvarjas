using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using WebApplication.SeedInterfaces;
using WebApplication.Users;

namespace WebApplication.Data.SeedService
{
    public class RoleSeedService : IRoleSeedService
    {
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public RoleSeedService(RoleManager<IdentityRole<int>> roleManager) 
        { 
            _roleManager = roleManager; 
        }

        public async Task SeedRoleAsync()
        {
            if (!await _roleManager.RoleExistsAsync(Roles.Administrators))
            {
                await _roleManager.CreateAsync(new IdentityRole<int> { Name = Roles.Administrators });
            }
        }
    }
}
