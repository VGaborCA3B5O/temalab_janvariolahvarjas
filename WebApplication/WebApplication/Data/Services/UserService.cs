using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Dtos;

namespace WebApplication.Data.Services
{
    public class UserService
    {
        public UserService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }

        public IEnumerable<UserDto> GetUsers() => DbContext.Users
            .Include(b => b.Posts).ToList()
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    Email = u.Email,
                    Admin = u.Admin,
                    Posts = u.Posts,
                });
    }
}
