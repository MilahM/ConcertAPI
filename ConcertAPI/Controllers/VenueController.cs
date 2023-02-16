using ConcertAPI.Models.Event_Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConcertAPI.Controllers
{
    public class VenueController : Controller
    {
        private readonly IEventsByVenueRepository repo;

        private readonly IConfiguration _configuration;
        public VenueController(IEventsByVenueRepository repo, IConfiguration configuration)
        {
            this.repo = repo;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VenueEvents() 
        {
            var client = new HttpClient();
            var clientId = _configuration.GetSection("client_id").Value;
            var clientSecret = _configuration.GetSection("client_secret").Value;
            var city = "";
            string url = $"https://api.seatgeek.com/2/events?venue.city={city}&client_id={clientId}";
            var response = client.GetStringAsync(url).Result;

            var venues = JsonConvert.DeserializeObject<Venue>(response);
            return View(venues);
        }

        public IActionResult Search(string searchTerm)
        {
            var searchResults = repo.SearchEvents(searchTerm);
            return View(searchResults);

        }
    }
}
