using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Entities;

namespace WebApplication.Data.SeedService
{
    public interface ISeedService
    {
        IDictionary<string, User> Users { get; }
        IDictionary<string, Post> Posts { get; }
        IDictionary<string, Like> Likes { get; }
        IDictionary<string, Comment> Comments { get; }
    }
}
