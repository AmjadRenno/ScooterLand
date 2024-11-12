namespace BlazorAppClientServer.Client.Models
{
    public class EntryModel
    {
        public string Name { get; set; }
        public string SelectedYdelse { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; } = DateTime.Today;
    }
}
