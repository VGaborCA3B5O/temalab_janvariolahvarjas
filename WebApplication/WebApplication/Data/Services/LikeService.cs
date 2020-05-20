﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Entities;

namespace WebApplication.Data.Services
{
    public class LikeService
    {
        public LikeService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }
        public IEnumerable<Like> GetLikes() => DbContext.Likes
                .Select(l => new Like
                {
                    Id = l.Id,
                    UserId = l.UserId,
                    PostId = l.PostId,
                }).ToList();
    }
}
