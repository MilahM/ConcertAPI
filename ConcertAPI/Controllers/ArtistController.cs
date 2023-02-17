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

        public IActionResult ArtistEvents()
        {
            return View();

        }

        public IActionResult Search(string searchTerm)
        {
            var newEvent = new Event();

            var newSearch = newEvent.ReplaceSpace(searchTerm);

            var searchResults = repo.SearchEvents(newSearch);
            return View(searchResults);

        }
    }
}
