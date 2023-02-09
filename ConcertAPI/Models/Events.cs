namespace ConcertAPI.Models
{
    public class Events
    {
        public string Type { get; set; }
        public DateTime Datetime_local { get; set; }
        public Venue Venue { get; set; }
        public string Url { get; set; }
    }
}
