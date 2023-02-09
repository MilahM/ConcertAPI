namespace ConcertAPI.Models.Event_Models
{
    public class Event
    {
        public string type { get; set; }
        public int id { get; set; }
        public DateTime datetime_utc { get; set; }
        public Venue venue { get; set; }
        public bool datetime_tbd { get; set; }
        public List<Performer> performers { get; set; }
        public bool is_open { get; set; }
        public List<object> links { get; set; }
        public DateTime datetime_local { get; set; }
        public bool time_tbd { get; set; }
        public string short_title { get; set; }
        public DateTime visible_until_utc { get; set; }
        public Stats stats { get; set; }
        public List<Taxonomy> taxonomies { get; set; }
        public string url { get; set; }
        public double score { get; set; }
        public DateTime announce_date { get; set; }
        public DateTime created_at { get; set; }
        public bool date_tbd { get; set; }
        public string title { get; set; }
        public double popularity { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public object access_method { get; set; }
        public object event_promotion { get; set; }
        public Announcements announcements { get; set; }
        public bool conditional { get; set; }
        public DateTime? enddatetime_utc { get; set; }
        public List<object> themes { get; set; }
        public List<object> domain_information { get; set; }
    }


}
