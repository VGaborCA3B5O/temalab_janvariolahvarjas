using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data.Entities
{
    public class User : IdentityUser<int>
    {
        //public int Id { get; set; }
        //public string UserName { get; set; }
        public string Profil { get; set; }
        public bool Admin { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
