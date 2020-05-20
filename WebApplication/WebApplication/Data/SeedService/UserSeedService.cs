using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Entities;
using WebApplication.SeedInterfaces;
using WebApplication.Users;

namespace WebApplication.Data.SeedService
{
    public class UserSeedService : IUserSeedService
    {
        private readonly UserManager<User> _userManager;

        public UserSeedService(UserManager<User> userManager) 
        { 
            _userManager = userManager;
        }

        public async Task SeedUserAsync()
        {
            if (!(await _userManager.GetUsersInRoleAsync(Roles.Administrators)).Any())
            {
                var user = new User
                {
                    Email = "admin@meme.hu",
                    Name = "Adminisztrátor",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "admin"
                };
                var createResult = await _userManager.CreateAsync(user, "$Administrator123");
                var addToRoleResult = await _userManager.AddToRoleAsync(user, Roles.Administrators);
                if (!createResult.Succeeded || !addToRoleResult.Succeeded)
                    throw new ApplicationException($"Administrator could not be created: " +
                    $"{string.Join(", ", createResult.Errors.Concat(addToRoleResult.Errors).Select(e => e.Description))}");
            }
        }
    }
}
