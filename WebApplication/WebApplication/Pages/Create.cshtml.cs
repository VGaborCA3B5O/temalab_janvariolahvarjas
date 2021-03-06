﻿using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication.Data.Entities;

namespace WebApplication.Pages.Post
{
    public class CreateModel : PageModel
    {
        private readonly Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly UserManager<User> _userManager;

        public CreateModel(Data.ApplicationDbContext context, IWebHostEnvironment environment, UserManager<User> userManager)
        {
            _context = context;
            _hostingEnvironment = environment;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
        ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Data.Entities.Post Post { get; set; }

        [BindProperty]
        public IFormFile Image { set; get; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Post.Title == null || Image == null)
            {
                return Page();
            }

            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(Image.FileName);
            string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Images", "Uploads", fileName);
            Image.CopyTo(new FileStream(filePath, FileMode.Create));
            Post.ImageName = fileName;
            Post.User = await _userManager.GetUserAsync(HttpContext.User);
            _context.Posts.Add(Post);       
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}
