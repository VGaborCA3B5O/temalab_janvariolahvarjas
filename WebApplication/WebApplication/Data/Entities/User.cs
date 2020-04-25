using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
