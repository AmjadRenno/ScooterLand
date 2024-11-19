namespace BlazorAppClientServer.Shared.Models
{
	public class Ydelse
	{
		public int YdelseId { get; set; }
		public string Navn { get; set; }
		public double Pris {  get; set; }
		public string Art {  get; set; }
		public double Timer { get; set; }

		public int? YdelseListId { get; set; }
		public YdelseListe? YdelseListe { get; set; }

    }
}
