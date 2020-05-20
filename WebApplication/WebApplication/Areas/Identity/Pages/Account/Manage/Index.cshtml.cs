using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication.Data.Entities;

namespace WebApplication.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public IndexModel(UserManager<User> userManager, SignInManager<User> signInManager, IWebHostEnvironment environment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _hostingEnvironment = environment;
        }

        public User LoggedInUser { get; set; }
        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        [BindProperty]
        public IFormFile Image { set; get; }

        public class InputModel
        {
            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "User Name")]
            public string Username { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Full Name")]
            public string Name { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Introduction")]
            public string Introduction { get; set; }
        }

        private async Task LoadAsync(User user)
        {
            LoggedInUser = user;

            Input = new InputModel
            {
                Username = await _userManager.GetUserNameAsync(user),
                Name = user.Name,
                Introduction = user.Introduction
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }



        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }
         
             
            var Username = await _userManager.GetUserNameAsync(user);
            if (Input.Username != Username)
            {
                var setNameResult = await _userManager.SetUserNameAsync(user, Input.Username);
                if (!setNameResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting User name for user with ID '{userId}'.");
                }
            }

            if (Input.Name != user.Name) 
            {
                user.Name = Input.Name;
            }
            if (Input.Introduction != user.Introduction) 
            {
                user.Introduction = Input.Introduction;
            }
            if (Image != null)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(Image.FileName);
                string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Images", "ProfilePictures", fileName);
                Image.CopyTo(new FileStream(filePath, FileMode.Create));
                user.ProfilePicture = fileName;
            }

            await _userManager.UpdateAsync(user);

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
