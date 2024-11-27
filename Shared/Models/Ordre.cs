namespace BlazorAppClientServer.Shared.Models
{
	public class Ordre
	{
		public int OrdreId { get; set; }
		public DateTime OrdreDate { get; set; }
		public bool Status { get; set; }

		public List<Ydelse> YdelseListe { get; set; } = new List<Ydelse>();

		public int? KundeId { get; set; }
		public Kunde? Kunde { get; set; }
		public string KundeNavn { get; set; }

		public int? MekanikerId { get; set; }
		public Mekaniker? Mekaniker { get; set; }

		public override string ToString()
		{
			return $"Id: {OrdreId}. OrdreDate: {OrdreDate}. Status: {Status}";
		}

	}
}
