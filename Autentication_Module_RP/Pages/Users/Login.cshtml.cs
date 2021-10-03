using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Autentication_Module_RP.Data;
using Autentication_Module_RP.Models;

namespace Autentication_Module_RP.Pages.Users
{
    public class LoginModel : PageModel
    {
        private readonly Autentication_Module_RP.Data.RDPCUserContext _context;

        public LoginModel(Autentication_Module_RP.Data.RDPCUserContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            if (Username != null && Password != null)
            {
                foreach (var user in _context.User)
                {
                    if (Username.Equals(user.Username) && Password.Equals(user.Password))
                    {
                        HttpContext.Session.SetString("username", Username);
                        return RedirectToPage("users");

                    }

                }

            }
            return Page();

        }

    }
}