namespace BlazorAppClientServer.Shared.Models
{
	public class Mekaniker
	{
		public int MekanikerId { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }

		public List<Ordre> OrdreListe { get; set; } = new List<Ordre>();

		public List<Mærke> MærkeListe { get; set; } = new List<Mærke>();

	}
}
