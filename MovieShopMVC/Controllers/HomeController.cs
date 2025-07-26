using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using MovieShopMVC.Models;
using System.Diagnostics;

namespace MovieShopMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovieService _movieService;
        private readonly int x = 1;
        public HomeController(ILogger<HomeController> logger, IMovieService movieService)
        {
            _logger = logger;
            _movieService = movieService;
            x = 5;
        }

       
        //https://localhost:7065/home/index
        //Routing
        [HttpGet]
        public IActionResult Index()
        {
            _movieService = new MovieService();
            //method(int x, IMovieService: movieService)
            //var movieService = new MovieService();
            //method(3, movieService)

            //var movieService1 = new MovieService1();
            //method(3, movieService1)
            var movies = _movieService.Get30HighestGrossingMovies();
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
