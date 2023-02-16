using ConcertAPI.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using ConcertAPI.Models.Event_Models;

namespace ConcertAPI
{
    public class EventsByVenueRepository : IEventsByVenueRepository
    {
        public EventsByVenueRepository()
        {
        }

        private readonly HttpClient _client;
        public EventsByVenueRepository(HttpClient client)
        {
            _client = client;
        }

        public IEnumerable<Event> SearchEvents(string searchTerm)
        {
            string auth = File.ReadAllText("appsettings.json");

            string authKey = JObject.Parse(auth).GetValue("client_id").ToString();

            string apiCall = $"https://api.seatgeek.com/2/events?venue.city={searchTerm}&client_id={authKey}";

            var response = _client.GetStringAsync(apiCall).Result;

            IEnumerable<Event> events = JsonConvert.DeserializeObject<Event>(response).Events;

            return events;
        }
    }
}
