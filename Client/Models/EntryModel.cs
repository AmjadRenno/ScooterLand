using BlazorAppClientServer.Shared.Models;

namespace BlazorAppClientServer.Client.Models
{
    public class EntryModel
    {
        public string Name { get; set; }
        public List<Ydelse> SelectedYdelser { get; set; } = new List<Ydelse>();
        public double Price { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
    }
}
