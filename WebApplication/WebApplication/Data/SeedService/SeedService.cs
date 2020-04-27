using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Entities;

namespace WebApplication.Data.SeedService
{
    public class SeedService : ISeedService
    {
        public IDictionary<string, User> Users { get; } = new[]
        {
            new User() { Id = 1, UserName = "Arnold",Admin=true,Profil = "Sziasztok!"},
            new User() {Id = 2, UserName = "Bence",Admin=false,Profil = "Sziasztok!"}

        }.ToDictionary(u => u.UserName);

        public IDictionary<string, Post> Posts { get; } = new[]
        {
            new Post{Id = 1, UserId=2,Content="cont1"},
            new Post{Id = 2, UserId=3, Content="cont2"}
        }.ToDictionary(p => p.Content);

        public IDictionary<string, Like> Likes { get; }

        public IDictionary<string, Comment> Comments { get; } = new[]
        {
            new Comment{Id = 1, Content="kom1", UserId=1, PostId=1 },
            new Comment{Id = 2, Content="kom2", UserId = 2, PostId=1},
        }.ToDictionary(c => c.Content);
    }
}
