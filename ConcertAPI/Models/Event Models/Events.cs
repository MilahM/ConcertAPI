namespace ConcertAPI.Models.Event_Models
{
    public class Events
    {
        public string Type { get; set; }
        public int Id { get; set; }
        //public DateTime datetime_utc { get; set; }
        public Venue Venue { get; set; }
        //public bool datetime_tbd { get; set; }
        public List<Performer> Performers { get; set; }
        //public bool is_open { get; set; }
        public List<object> Links { get; set; }
        public DateTime Datetime_local { get; set; }
        //public bool time_tbd { get; set; }
        //public string short_title { get; set; }
        //public DateTime visible_until_utc { get; set; }
        //public Stats stats { get; set; }
        //public List<Taxonomy> taxonomies { get; set; }
        public string Url { get; set; }
        //public double score { get; set; }
        //public DateTime announce_date { get; set; }
        //public DateTime created_at { get; set; }
        //public bool date_tbd { get; set; }
        //public string title { get; set; }
        //public double popularity { get; set; }
        //public string Description { get; set; }
        //public string status { get; set; }
        //public object access_method { get; set; }
        //public object event_promotion { get; set; }
        public Announcements Announcements { get; set; }
        //public bool conditional { get; set; }
        //public DateTime? enddatetime_utc { get; set; }
        //public List<object> themes { get; set; }
        //public List<object> domain_information { get; set; }
    }


}
