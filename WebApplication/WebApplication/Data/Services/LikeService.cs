using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Dtos;

namespace WebApplication.Data.Services
{
    public class LikeService
    {
        public LikeService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }
        public IEnumerable<LikeDto> GetLikes() => DbContext.Likes
            .Include(l => l.User)
            .Include(l => l.Post)
                .Select(l => new LikeDto
                {
                    Id = l.Id,
                    UserId = l.UserId,
                    User = l.User,
                    Post = l.Post,
                    PostId = l.PostId,
                });
    }
}
