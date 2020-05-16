using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication.Pages.Post
{
    public class CreateModel : PageModel
    {
        private readonly Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;

        public CreateModel(Data.ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            this.hostingEnvironment = environment;
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (this.Image != null)
            {
                string fileName = "7" + Path.GetExtension(Image.FileName); // next id ?
                string filePath = Path.Combine(hostingEnvironment.WebRootPath, "Images", fileName);
                this.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                this.Post.ImageName = fileName;
            }

            _context.Posts.Add(Post);
            await _context.SaveChangesAsync(); // itt a baj
            return RedirectToPage("./Index");
        }
    }
}
