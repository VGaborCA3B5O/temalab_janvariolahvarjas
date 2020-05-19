using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data.Entities
{
    public class User : IdentityUser<int>
    {
        // Already has Id, UserName
        public string Profil { get; set; }
        public bool Admin { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
