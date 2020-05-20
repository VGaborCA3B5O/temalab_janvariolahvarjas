using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication.Services;

namespace WebApplication
{
    public class SearchModel : PageModel
    {

        public IEnumerable<Data.Entities.Post> Posts { get; private set; }
        public List<Data.Entities.Post> FoundPosts { get; private set; } = new List<Data.Entities.Post>();
        public Data.Entities.Post p { get; private set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public string b;

        public SearchModel([FromServices]PostService postService)
        {
            Posts = postService.GetPosts();
        }

        public async Task OnGetAsync()
        {
            if (SearchString != null)
            {
                foreach (var post in Posts)
                {
                    if (post.Title.IndexOf(SearchString, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        FoundPosts.Add(post);
                    }
                }
            }
        }
    }
}
