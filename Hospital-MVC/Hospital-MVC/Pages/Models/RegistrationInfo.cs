using System.ComponentModel.DataAnnotations;

namespace Hospital_MVC.Pages.Models
{
	public class RegistrationInfo
	{
		[Key]
		[Required]
		[MaxLength(50, ErrorMessage ="Must be lesser than 50 characters")]
		[DataType(DataType.EmailAddress,ErrorMessage ="Must be an email")]
		public string EmailID { get; set; }

		//p for patient, d for doctor
		public string UserType {  get; set; }
	}
}
