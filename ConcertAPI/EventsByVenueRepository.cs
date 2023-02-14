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
        public List<Events> GetEventByVenue(string apiCall)
        {
            var client = new HttpClient();

            var artistUrlResponse = client.GetStringAsync(apiCall).Result;

            var artistEvents = JObject.Parse(artistUrlResponse)["events"].ToString();

            List<Events> events = JsonConvert.DeserializeObject<List<Events>>(artistEvents);

            return events;
        }
    }
}
