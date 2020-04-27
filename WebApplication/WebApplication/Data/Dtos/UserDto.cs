using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Entities;

namespace WebApplication.Data.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Profil { get; set; }
        public bool Admin { get; set; }
        public string Email { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
