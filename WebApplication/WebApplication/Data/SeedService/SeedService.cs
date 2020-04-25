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
            new User() { Id = 1, UserName = "xygeza"},
            new User() {Id = 2, UserName = "xyvalaki"}
        }.ToDictionary(a => a.UserName);

        public IList<Post> Posts { get; }
        IList<Post> ISeedService.Posts { get => Posts; set => throw new NotImplementedException(); }

        public SeedService()
        {
            Posts = new List<Post>()
            {
                new Post
                {
                    Id = 1,
                    Caption = "this is a caption",
                    PictureSource = "picture is not found right now"
                },
                new Post
                {
                     Id = 2,
                    Caption = "this is a caption 2",
                    PictureSource = "picture is not found right now 2"
                },
                new Post
                {
                     Id = 3,
                    Caption = "this is a caption 3",
                    PictureSource = "picture is not found right now 3"
                }
            };
        }

    }
}
