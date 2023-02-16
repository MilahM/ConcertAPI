namespace ConcertAPI.Models.Event_Models
{
    public class Venue
    {
        public IEnumerable<Venue> events { get; set; }
        public string State { get; set; }
        //public string Name_v2 { get; set; }
        //public string Postal_code { get; set; }
        public string Name { get; set; }
        //public List<object> Links { get; set; }
        //public string Timezone { get; set; }
        public string Url { get; set; }
        //public double score { get; set; }
        //public Location Location { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        //public bool has_upcoming_events { get; set; }
        //public int num_upcoming_events { get; set; }
        public string City { get; set; }
        //public string slug { get; set; }
        //public string Extended_address { get; set; }
        //public int Id { get; set; }
        //public int popularity { get; set; }
        //public object access_method { get; set; }
        //public int metro_code { get; set; }
        //public int capacity { get; set; }
        //public string Display_location { get; set; }
    }


}
