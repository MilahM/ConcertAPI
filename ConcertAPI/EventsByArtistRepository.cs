using ConcertAPI.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using ConcertAPI.Models.Event_Models;
using System;

namespace ConcertAPI
{
    public class EventsByArtistRepository : IEventsByArtistRepository
    {
        public EventsByArtistRepository()
        {
        }
        private readonly HttpClient _client;

        public EventsByArtistRepository(HttpClient client)
        {
            _client = client;
        }

        public IEnumerable<Event> SearchEvents(string searchTerm)
        {
            string auth = File.ReadAllText("appsettings.json");

            string authKey = JObject.Parse(auth).GetValue("client_id").ToString();

            var newEvent = new Event();

            var artistName = newEvent.ReplaceSpace(searchTerm);

            string apiCall = $"https://api.seatgeek.com/2/events?performers.slug={searchTerm}&client_id={authKey}";

            var response = _client.GetStringAsync(apiCall).Result;

            IEnumerable<Event> events = JsonConvert.DeserializeObject<Event>(response).Events;

            return events;

        }

    }
}


