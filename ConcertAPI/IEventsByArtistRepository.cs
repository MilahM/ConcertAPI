using ConcertAPI.Models;
using ConcertAPI.Models.Event_Models;

namespace ConcertAPI
{
    public interface IEventsByArtistRepository
    {
        public IEnumerable<Event> SearchEvents(string searchTerm);
    }
}
