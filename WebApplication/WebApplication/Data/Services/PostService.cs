using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Dtos;

namespace WebApplication.Data.Services
{
    public class PostService
    {
        public PostService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }

        public IEnumerable<PostDto> GetPosts() => DbContext.Posts
            .Include(p => p.User)
            .Include(p => p.Comments)
            .Include(p => p.Likes)
                .Select(p => new PostDto
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    User = p.User,
                    Content = p.Content,
                    Comments = p.Comments,
                    Likes = p.Likes

                });
    }
}
