using System.ComponentModel.DataAnnotations;

namespace BlazorAppClientServer.Shared.Models
{
	public class Værkfører
	{
		public int VærkførerId { get; set; }
		[Required(ErrorMessage = "Email er påkrævet")]
		[EmailAddress(ErrorMessage = "Ikke en gyldig Email adresse")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Password er påkrævet")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
