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
    public class IndexModel : PageModel
    {
        private readonly Autentication_Module_RP.Data.RDPCUserContext _context;

        public IndexModel(Autentication_Module_RP.Data.RDPCUserContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
