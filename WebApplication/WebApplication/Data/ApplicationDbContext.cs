using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data.Entities;
using WebApplication.Data.EntityConfiguration;
using WebApplication.Data.SeedService;

namespace WebApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly ISeedService _seedService;
        public ApplicationDbContext(DbContextOptions options, ISeedService seedService) : base(options)
            => _seedService = seedService;
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration(_seedService));
            modelBuilder.ApplyConfiguration(new PostEntityConfiguration(_seedService));
        }
    }
}
