using System.Collections.Generic;
using System.Linq;
using WebApplication.Data.Entities;
using WebApplication.Services.SeedService.SeedInterfaces;

namespace WebApplication.Services.SeedService
{
    public class SeedService : ISeedService
    {
        public IDictionary<string, User> Users { get; } = new[]
        {
            new User() {Id = 1, UserName = "arnold", Name ="Arnold", Admin = true, Introduction = "Sziasztok!", Email = "arnold@valami.hu"},
            new User() {Id = 2, UserName = "bence", Name ="Bence", Admin = false, Introduction = "Sziasztok!", Email = "bence@valami.hu"},
            new User() {Id = 3, UserName = "laura", Name ="Laura", Admin = false, Introduction = "Sziasztok!", Email = "laura@valami.hu"}

        }.ToDictionary(u => u.UserName);

        public IDictionary<string, Post> Posts { get; } = new[]
        {
            new Post{Id = 1, UserId = 1, Title = "Ugye nem csak én híztam be", ImageName="1.jpg"},
            new Post{Id = 2, UserId = 2, Title = "Ez bárcsak én lennék most", ImageName="2.jpg"},
            new Post{Id = 3, UserId = 3, Title = "Oké Pali bá", ImageName="3.jpg"},
            new Post{Id = 4, UserId = 2, Title = "Ideje megtanulni kezetmosni", ImageName="4.jpg"},
            new Post{Id = 5, UserId = 1, Title = "Fujj", ImageName="5.jpg"},
            new Post{Id = 6, UserId = 3, Title = "Norbi", ImageName="6.jpg"},
            new Post{Id = 7, UserId = 2, Title = "Milyen igaz :(", ImageName="7.jpg"},
            new Post{Id = 8, UserId = 3, Title = "Korona megoldja úgyis", ImageName="8.jpg"},
            new Post{Id = 9, UserId = 3, Title = "Szep", ImageName="9.jpg"},
            new Post{Id = 10, UserId = 1, Title = "Szilárd papa", ImageName="10.jpg"}
        }.ToDictionary(p => p.Title);
    }
}
