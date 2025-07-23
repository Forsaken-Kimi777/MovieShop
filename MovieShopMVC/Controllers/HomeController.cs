using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using MovieShopMVC.Models;
using System.Diagnostics;

namespace MovieShopMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //https://localhost:7065/home/index
        //Routing
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.someTitle = "Movie Shop Home Page Title";
            //ViewData["sometitle"] = "Some Title";
            ViewBag.descrition = new List<string>() {"abc", "edf"};

            // coming from the database
            var movies = new List<MovieCard> {
                new MovieCard { Title = "Inception", Id = 1, PosterUrl = "https://image.tmdb.org/t/p/w342//9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg" },
                new MovieCard { Title = "Interstellar", Id = 2, PosterUrl = "https://image.tmdb.org/t/p/w342//gEU2QniE6E77NI6lCU6Mx1nBVxI.jpg" },
                new MovieCard { Title = "The Dark Knight", Id = 3, PosterUrl = "https://image.tmdb.org/t/p/w342//qJ2tW6WMUDux911r6m7haRef0WH.jpg" },
                new MovieCard { Title = "Deadpool", Id = 4, PosterUrl = "https://image.tmdb.org/t/p/w342//yGSxMiF0cYuAiyuve5DA6bnWEaI.jpg" },
                new MovieCard { Title = "The Avengers", Id = 5, PosterUrl = "https://image.tmdb.org/t/p/w342//RYMX2wcKCBAr24UyPD7xwmjaTn.jpg" },
            };
            return View(movies);
        }
        [HttpGet]
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
