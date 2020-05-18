using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Entities;
using WebApplication.SeedInterfaces;

namespace WebApplication.Data.SeedService
{
    public class SeedService : ISeedService
    {
        public IDictionary<string, User> Users { get; } = new[]
        {
            new User() { Id = 1, UserName = "Arnold",Admin=true,Profil = "Sziasztok!",Email="Arnold@valami.hu"},
            new User() {Id = 2, UserName = "Bence",Admin=false,Profil = "Sziasztok!",Email="Bence@valami.hu"},
            new User() {Id = 3, UserName = "Laura",Admin=false,Profil = "Sziasztok!",Email="Laura@valami.hu"}

        }.ToDictionary(u => u.UserName);

        public IDictionary<string, Post> Posts { get; } = new[]
        {
            new Post{Id = 1, UserId=1, Title="Elso Post", ImageName="1.jpg"},
            new Post{Id = 2, UserId=2, Title="Masodik Post", ImageName="2.jpg"},
            new Post{Id = 3, UserId=3, Title="Harmadik Post", ImageName="3.jpg"}
        }.ToDictionary(p => p.Title);

        public IDictionary<string, Like> Likes { get; }

        public IDictionary<string, Comment> Comments { get; } = new[]
        {
            new Comment{Id = 1, Content="kom1", UserId=1, PostId=1 },
            new Comment{Id = 2, Content="kom2", UserId = 2, PostId=1},
        }.ToDictionary(c => c.Content);
    }
}
