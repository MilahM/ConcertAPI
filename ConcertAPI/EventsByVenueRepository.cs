using ConcertAPI.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ConcertAPI
{
    public class EventsByVenueRepository
    {
        public EventsByVenueRepository()
        {
            string auth = File.ReadAllText("appsettings.json");

            string authKey = JObject.Parse(auth).GetValue("client_id").ToString();

            //var venueCity = Console.ReadLine();

            string apiCall2 = $"https://api.seatgeek.com/2/events?venue.city={venueCity}&client_id={authKey}";
        }
        private readonly HttpClient _client;
        public EventsByVenueRepository(HttpClient client)
        {
            _client = client;
        }
        public static List<Venue> GetEventByVenue(string apiCall)
        {
            var client = new HttpClient();

            var venueUrlResponse = client.GetStringAsync(apiCall).Result;

            var venueEvents = JObject.Parse(venueUrlResponse)["events"].ToString();

            List<Venue> events = JsonConvert.DeserializeObject<List<Venue>>(venueEvents);

            foreach (var item in events)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.name_v2);
                Console.WriteLine(item.city);
                Console.WriteLine(item.state);
                Console.WriteLine(item.url);
            }

            return events;
        }
    }
}
