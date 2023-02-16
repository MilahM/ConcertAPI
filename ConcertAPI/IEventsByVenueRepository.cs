using ConcertAPI.Models;
using ConcertAPI.Models.Event_Models;

namespace ConcertAPI
{
    public interface IEventsByVenueRepository
    {
        public IEnumerable<Event> SearchEvents(string searchTerm);
    }
}
