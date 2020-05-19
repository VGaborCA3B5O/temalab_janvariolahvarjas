using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication.Data.Services;

namespace WebApplication
{
    public class SearchModel : PageModel
    {

        public IEnumerable<WebApplication.Data.Entities.Post> Post { get; private set; }
        public Data.Entities.Post p { get; private set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public string b;

        public SearchModel([FromServices]PostService postService)
        {           
            Post = postService.GetPosts();
        }

        public async Task OnGetAsync()
        {
            if (SearchString != null)
            {
                foreach (var post in Post)
                {
                    if (post.Title == SearchString)
                    {
                        p = post;
                        break;
                    }
                }
            }
        }

        }
}