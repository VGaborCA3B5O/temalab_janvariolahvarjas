using System.Collections.Generic;
using WebApplication.Data.Entities;

namespace WebApplication.Services.SeedService.SeedInterfaces
{
    public interface ISeedService
    {
        IDictionary<string, User> Users { get; }
        IDictionary<string, Post> Posts { get; }
    }
}
