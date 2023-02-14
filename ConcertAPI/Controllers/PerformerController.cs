using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ConcertAPI.Controllers
{
    public class PerformerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
