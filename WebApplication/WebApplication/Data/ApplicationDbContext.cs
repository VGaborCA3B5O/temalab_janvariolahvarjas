﻿using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data.Entities;
using WebApplication.Data.EntityConfiguration;
using WebApplication.Services.SeedService.SeedInterfaces;

namespace WebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        private readonly ISeedService _seedService;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ISeedService seedService) : base(options) => _seedService = seedService;

        public DbSet<Post> Posts { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.ApplyConfiguration(new UserEntityConfiguration(_seedService));
            modelBuilder.ApplyConfiguration(new PostEntityConfiguration(_seedService));
        }
    }
}
