using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data;
using WebApplication.Data.Entities;

namespace WebApplication.Pages.Post
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication.Data.ApplicationDbContext _context;

        public IndexModel(WebApplication.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<WebApplication.Data.Entities.Post> Post { get;set; }

        public async Task OnGetAsync()
        {
            Post = await _context.Posts
                .Include(p => p.User).ToListAsync();
        }
    }
}
