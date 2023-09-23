using Hospital_MVC.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hospital_MVC.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginInfo Login {  get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await Task.Delay(100);

            return RedirectToPage();
        }
    }
}
