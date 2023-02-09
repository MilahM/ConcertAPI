using ConcertAPI.Models;

namespace ConcertAPI
{
    public interface IEventsByArtistRepository
    {
        public List<Events> GetEventByArtist(string apiCall);
    }
}
