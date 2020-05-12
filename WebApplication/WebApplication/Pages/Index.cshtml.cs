using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication.Data;
using WebApplication.Data.Entities;
using WebApplication.Data.Services;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<User> Users { get; private set; }
        public IEnumerable<Post> Posts { get; private set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet([FromServices]UserService userService, [FromServices]PostService postService)
        {
            Users = userService.GetUsers();
            Posts = postService.GetPosts();
        }
    }
}
