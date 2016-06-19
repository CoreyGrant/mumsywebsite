using System.ComponentModel.DataAnnotations;

namespace MumsyWebsite.Models.Admin
{
	public class LoginModel
	{
		[Required]
		public string Password { get; set; }
	}
}