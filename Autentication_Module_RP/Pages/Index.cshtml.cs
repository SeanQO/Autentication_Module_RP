using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autentication_Module_RP.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Msg { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Username.Equals("s") && Password.Equals("s"))
            {
                HttpContext.Session.SetString("username", Username);
                return RedirectToPage("/users/index");
            }
            else
            {
                Msg = "Invalid";
                return Page();
            }
        }
    }
}
