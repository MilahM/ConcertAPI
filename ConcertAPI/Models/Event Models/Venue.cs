namespace ConcertAPI.Models.Event_Models
{
    public class Venue
    {
        public IEnumerable<Venue> events { get; set; }
        public string State { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }


}
