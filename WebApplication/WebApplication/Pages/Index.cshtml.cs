using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication.Data.Entities;
using WebApplication.Data.Services;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<User> Users { get; private set; }
        public IEnumerable<Data.Entities.Post> Posts { get; private set; }

        public IndexModel()
        {
        }

        public void OnGet([FromServices]UserService userService, [FromServices]PostService postService)
        {
            Users = userService.GetUsers();
            Posts = postService.GetPosts().OrderByDescending(x => x.Id);
        }
    }
}
