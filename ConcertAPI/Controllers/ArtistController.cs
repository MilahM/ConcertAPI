using ConcertAPI.Models;
using ConcertAPI.Models.Event_Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
            var client = new HttpClient();
            var clientId = _configuration.GetSection("client_id").Value;
            var clientSecret = _configuration.GetSection("client_secret").Value;
            string url = $"https://api.seatgeek.com/2/events?client_id={clientId}&client_secret={clientSecret}";
            var response = client.GetStringAsync(url).Result;

            var root = JsonConvert.DeserializeObject<Root>(response);
            return View(root);

            #region Kamilah's code sandbox
            //IEnumerable<Events> events = null;

            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://localhost:7232/api/");

            //    var responseTask = client.GetAsync("events");

            //    responseTask.Wait();

            //    var result = responseTask.Result;

            //    if (result.IsSuccessStatusCode)
            //    {
            //        var readTask = result.Content.ReadAsAsync<IList<Events>>();
            //        readTask.Wait();

            //        events = readTask.Result;
            //    }
            //    else
            //    {   
            //        events = Enumerable.Empty<Events>();
            //        ModelState.AddModelError(string.Empty, "Server error try after some time.");
            //    }
            //}
            #endregion
        }

    }
}
