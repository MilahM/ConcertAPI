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

        public IActionResult Search(string searchTerm)
        {
            var searchResults = repo.SearchEvents(searchTerm);
            return View(searchResults);

        }

        public IActionResult VenueEvents()
        {
            return View();
        }
    }
}
