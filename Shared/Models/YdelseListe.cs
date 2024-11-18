namespace BlazorAppClientServer.Shared.Models
{
	public class YdelseListe
	{
		public int YdelseListeId { get; set; }
		public List<Ydelse> ydelseListe { get; set; } = new List<Ydelse>();

        public int OrdreId { get; set; }
        public Ordre Ordre { get; set; }

        public int YdelseId { get; set; }
        public Ydelse Ydelse { get; set; }

        public int? MekanikerId { get; set; }  // Nullable in case mechanic selection is optional
        public Mekaniker Mekaniker { get; set; }

    }
}
