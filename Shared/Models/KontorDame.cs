using System.ComponentModel.DataAnnotations;

namespace BlazorAppClientServer.Shared.Models
{
	public class KontorDame
	{
		public int KontorDameId { get; set; }
		[Required(ErrorMessage = "Email er påkrævet")]
		[EmailAddress(ErrorMessage = "Ikke en gyldig Email adresse")]
		public string Email { get; set; }
		[Required (ErrorMessage = "Password er påkrævet")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
