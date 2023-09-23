using Hospital_MVC.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Net.Mime.MediaTypeNames;

namespace Hospital_MVC.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public RegistrationInfo Registration { get; set; }
        public string ImageSource { get; private set; } = "./images/patient-1295570_1280.png";

		public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await Task.Delay(100);

            return RedirectToPage("Login");
        }

        public void SetImage()
        {
            if(Registration.UserType == "p")
			{
                ImageSource = "./images/patient-1295570_1280.png";
			}
            else
            {
                ImageSource = "./Images/doctor-1295581_1280.png";
			}
        }
    }
}
