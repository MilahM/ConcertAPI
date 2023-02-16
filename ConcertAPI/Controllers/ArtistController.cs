using ConcertAPI.Models;
using ConcertAPI.Models.Event_Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace ConcertAPI.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IEventsByArtistRepository repo;

        private readonly IConfiguration _configuration;
        public ArtistController(IEventsByArtistRepository repo, IConfiguration configuration)
        {
            this.repo = repo;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult ArtistEvents()
        //{
        //    var client = new HttpClient();
        //    var clientId = _configuration.GetSection("client_id").Value;
        //    var clientSecret = _configuration.GetSection("client_secret").Value;
        //    var artistName = "";
        //    string url = $"https://api.seatgeek.com/2/events?performers.slug={artistName}&client_id={clientId}";
        //    var response = client.GetStringAsync(url).Result;

        //    var events = JsonConvert.DeserializeObject<Event>(response);
        //    return View(events);

        //}
        public IActionResult Search(string searchTerm)
        {
            var searchResults = repo.SearchEvents(searchTerm);
            return View(searchResults);

        }

        public IActionResult ArtistEvents()
        {
            return View();

        }
    }
}
