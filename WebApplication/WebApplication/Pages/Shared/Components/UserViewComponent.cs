using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Pages.Shared.Components
{
    public class UserViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(WebApplication.Data.Entities.User user)
        {
            return View(user);
        }
    }
}
