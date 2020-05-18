using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication.Data.Entities;
using WebApplication.Data.Services;

namespace WebApplication
{
    public class ProfilModel : PageModel
    {
        public Data.Entities.User Userer { get; set; }
        private readonly UserManager<User> _userManager;

        public ProfilModel(UserManager<User> userManager)
        {
            _userManager = userManager;
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
                    Userer = user;
                }
            }
            if (Userer == null)
            {
                return NotFound();
            }
            return Page();


        }

    }
}