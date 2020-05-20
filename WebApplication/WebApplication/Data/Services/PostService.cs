using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Data.Entities;

namespace WebApplication.Data.Services
{
    public class PostService
    {
        public PostService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }

        public IEnumerable<Post> GetPosts() => DbContext.Posts
            .Include(p => p.User)
                .Select(p => new Post
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    User = p.User,
                    Title = p.Title,
                    ImageName = p.ImageName
                }).ToList();

        public Post GetPostById(int? id)
        {
            return DbContext.Posts
            .Include(p => p.User)
                .Select(p => new Post
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    User = p.User,
                    Title = p.Title,
                    ImageName = p.ImageName
                })
                .FirstOrDefault(p => p.Id == id);
        }
    }
}
