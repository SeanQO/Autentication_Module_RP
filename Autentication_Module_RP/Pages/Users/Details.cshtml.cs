using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Autentication_Module_RP.Data;
using Autentication_Module_RP.Models;

namespace Autentication_Module_RP.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly Autentication_Module_RP.Data.RDPCUserContext _context;

        public DetailsModel(Autentication_Module_RP.Data.RDPCUserContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.ID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
