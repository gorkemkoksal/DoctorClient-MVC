using System.ComponentModel.DataAnnotations;

namespace Hospital_MVC.Pages.Models
{
	public class LoginInfo:RegistrationInfo
	{
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		public bool RememberMe {  get; set; }
	}
}
