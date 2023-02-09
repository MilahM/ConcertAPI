using ConcertAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace ConcertAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            //List<Events> eventsList = new List<Events>();
            //using(var httpClient = new HttpClient())
            //{
            //    using (var response = await httpClient.GetAsync("http://localhost:7232/api/Events"))
            //    {
            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        eventsList = JsonConvert.DeserializeObject<List<Events>>(apiResponse);
            //    }
            //}
            return View();
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}