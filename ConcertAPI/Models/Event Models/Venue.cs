namespace ConcertAPI.Models.Event_Models
{
    public class Venue
    {
        public string state { get; set; }
        public string name_v2 { get; set; }
        public string postal_code { get; set; }
        public string name { get; set; }
        public List<object> links { get; set; }
        public string timezone { get; set; }
        public string url { get; set; }
        public double score { get; set; }
        public Location location { get; set; }
        public string address { get; set; }
        public string country { get; set; }
        public bool has_upcoming_events { get; set; }
        public int num_upcoming_events { get; set; }
        public string city { get; set; }
        public string slug { get; set; }
        public string extended_address { get; set; }
        public int id { get; set; }
        public int popularity { get; set; }
        public object access_method { get; set; }
        public int metro_code { get; set; }
        public int capacity { get; set; }
        public string display_location { get; set; }
    }


}
