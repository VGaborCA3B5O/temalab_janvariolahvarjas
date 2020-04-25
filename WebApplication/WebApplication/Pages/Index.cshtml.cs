using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication.Data;
using WebApplication.Data.Entities;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        public IReadOnlyCollection<Post> Posts { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet([FromServices]ApplicationDbContext context)
        {
            Posts = context.Posts.ToList();
        }
    }
}
