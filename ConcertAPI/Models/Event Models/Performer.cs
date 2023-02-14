namespace ConcertAPI.Models.Event_Models
{
    public class Performer
    {
        public IEnumerable<Performer> events { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        //public string image { get; set; }
        public int Id { get; set; }
        //public Images images { get; set; }
        //public List<Division> divisions { get; set; }
        //public bool has_upcoming_events { get; set; }
        //public bool primary { get; set; }
        //public Stats stats { get; set; }
        //public List<Taxonomy> taxonomies { get; set; }
        //public string image_attribution { get; set; }
        public string Url { get; set; }
        //public double score { get; set; }
        //public string slug { get; set; }
        //public int? home_venue_id { get; set; }
        //public string short_name { get; set; }
        //public int num_upcoming_events { get; set; }
        //public object colors { get; set; }
        //public string image_license { get; set; }
        //public int popularity { get; set; }
        //public bool home_team { get; set; }
        public Location Location { get; set; }
        //public string image_rights_message { get; set; }
        //public List<Genre> genres { get; set; }
        //public bool? away_team { get; set; }
    }


}
