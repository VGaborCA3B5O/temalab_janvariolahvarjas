using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication.Data;
using WebApplication.Data.Dtos;
using WebApplication.Data.Entities;
using WebApplication.Data.Services;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<UserDto> Users { get; private set; }
        public IEnumerable<PostDto> Post { get; private set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet([FromServices]UserService userService, [FromServices]PostService postService)
        {
            Users = userService.GetUsers();
            Post = postService.GetPosts();
        }
    }
}
