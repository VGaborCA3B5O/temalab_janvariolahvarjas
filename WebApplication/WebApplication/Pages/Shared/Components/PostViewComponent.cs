using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data.Entities;

namespace WebApplication.Pages.Components
{
    public class PostViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Post p)
        {
            return View(p);
        } 
    }
}
