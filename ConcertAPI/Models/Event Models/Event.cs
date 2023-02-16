using ConcertAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ConcertAPI.Models.Event_Models
{
    public class Event
    {
        public readonly IEventsByArtistRepository artistRepository;
        public IEnumerable<Event> Events { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        
        public Venue Venue { get; set; }
       
        public List<Performer> Performers { get; set; }
       
        public DateTime Datetime_local { get; set; }
       
        public string Url { get; set; }
        
        public string name { get; set; }
        public static List<Event> SearchList { get; set; } = new List<Event>();


    }


}
