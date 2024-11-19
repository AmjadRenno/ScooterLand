namespace BlazorAppClientServer.Shared.Models
{
	public class YdelseListe
	{
		public int YdelseListeId { get; set; }
		public List<Ydelse> ydelseListe { get; set; } = new List<Ydelse>();
    }
}
