using ConcertAPI.Models;
using ConcertAPI.Models.Event_Models;

namespace ConcertAPI
{
    public interface IEventsByVenueRepository
    {
        public List<Events> GetEventByVenue(string apiCall);
    }
}
