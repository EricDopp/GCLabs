using Microsoft.AspNetCore.Mvc;
using PauperReddit.Models;
using PauperReddit.Models.Interfaces;
using System.Diagnostics;

namespace PauperReddit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRedditService _redditService;

        public HomeController(ILogger<HomeController> logger, IRedditService redditService)
        {
            _logger = logger;
            _redditService = redditService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _redditService.GetDataJsonAsync();
            return View(data);
        }

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