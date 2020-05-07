using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.SeedService;
using WebApplication.Data.Entities;
using WebApplication.SeedInterfaces;

namespace WebApplication.Data.EntityConfiguration
{
    public class CommentEntitiyConfiguration : IEntityTypeConfiguration<Comment>
    {
        private readonly ISeedService _seedService;
        public CommentEntitiyConfiguration(ISeedService seedService) => _seedService = seedService;

        public void Configure(EntityTypeBuilder<Comment> builder) => builder.HasData(_seedService.Comments.Values);
    }
}
