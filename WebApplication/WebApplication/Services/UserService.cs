using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Data;
using WebApplication.Data.Entities;

namespace WebApplication.Services
{
    public class UserService
    {
        public UserService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }

        public IEnumerable<User> GetUsers() => DbContext.Users
            .Include(b => b.Posts)
                .Select(u => new User
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    Email = u.Email,
                    Introduction = u.Introduction,
                    Admin = u.Admin,
                    Posts = u.Posts,
                }).ToList();
    }
}
