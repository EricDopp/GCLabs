using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OMDB.Models;
using System.Diagnostics;

namespace OMDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieSearchForm()
        {
            return View("MovieSearch");
        }

        [HttpPost]
        public async Task<IActionResult> MovieSearchResults([FromForm] string title)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"http://www.omdbapi.com/?apikey=ad7d088a&t={title}");

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Movie movie = JsonConvert.DeserializeObject<Movie>(responseBody);

                    return View("MovieSearch", movie);
                }
                else
                {
                    return RedirectToAction("Error");
                }
            }
        }
        [HttpGet]
        public async Task<IActionResult> MovieNightForm()
        {
            return View("MovieNight");
        }

        [HttpPost]
        public async Task<IActionResult> MovieNightResults([FromForm] string Title1, string Title2, string Title3)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response1 = await client.GetAsync($"http://www.omdbapi.com/?apikey=ad7d088a&t={Title1}");
                HttpResponseMessage response2 = await client.GetAsync($"http://www.omdbapi.com/?apikey=ad7d088a&t={Title2}");
                HttpResponseMessage response3 = await client.GetAsync($"http://www.omdbapi.com/?apikey=ad7d088a&t={Title3}");

                if (response1.IsSuccessStatusCode && response2.IsSuccessStatusCode && response3.IsSuccessStatusCode)
                {
                    string responseBody1 = await response1.Content.ReadAsStringAsync();
                    string responseBody2 = await response2.Content.ReadAsStringAsync();
                    string responseBody3 = await response3.Content.ReadAsStringAsync();

                    Movie movie1 = JsonConvert.DeserializeObject<Movie>(responseBody1);
                    Movie movie2 = JsonConvert.DeserializeObject<Movie>(responseBody2);
                    Movie movie3 = JsonConvert.DeserializeObject<Movie>(responseBody3);

                    List<Movie> movies = new List<Movie>();
                    movies.Add(movie1);
                    movies.Add(movie2);
                    movies.Add(movie3);

                    return View("MovieNight", movies);
                }
                else
                {
                    return RedirectToAction("Error");
                }
            }
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