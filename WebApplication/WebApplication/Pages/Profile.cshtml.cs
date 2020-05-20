using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication.Data.Entities;
using WebApplication.Data.Services;

namespace WebApplication
{
    public class ProfileModel : PageModel
    {
        public IEnumerable<Post> Post { get; private set; }
        public User DisplayedUser { get; set; }
        private readonly UserManager<User> _userManager;

        public ProfileModel(UserManager<User> userManager, [FromServices]PostService postService)
        {
            _userManager = userManager;
            Post = postService.GetPosts();
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            foreach (var user in _userManager.Users)
            {
                if (user.Id == id)
                {
                    DisplayedUser = user;
                }
            }
         
            if (DisplayedUser == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
