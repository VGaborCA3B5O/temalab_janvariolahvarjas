using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            .Include(p => p.Comments)
            .Include(p => p.Likes)
                .Select(p => new Post
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    User = p.User,
                    Title = p.Title,
                    Comments = p.Comments,
                    Likes = p.Likes,
                    ImageName = p.ImageName
                }).ToList();

        public Post GetPostById(int? id)
        {
            return DbContext.Posts
            .Include(p => p.User)
            .Include(p => p.Comments)
            .Include(p => p.Likes)
                .Select(p => new Post
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    User = p.User,
                    Title = p.Title,
                    Comments = p.Comments,
                    Likes = p.Likes,
                    ImageName = p.ImageName
                })
                .FirstOrDefault(p => p.Id == id);
        }
    }
}
