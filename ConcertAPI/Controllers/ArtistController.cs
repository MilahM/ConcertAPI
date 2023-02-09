using Microsoft.AspNetCore.Mvc;

namespace ConcertAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IEventsByArtistRepository repo;
        public ArtistController(IEventsByArtistRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IActionResult ArtistEvents(string apiCall)
        {
            var events = repo.GetEventByArtist(apiCall);
            return View(events);
        }
    }
}
