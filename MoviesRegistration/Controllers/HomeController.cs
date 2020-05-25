using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesRegistration.Models;

namespace MoviesRegistration.Controllers
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

        public static DateTime GetDateTime()
        {
            DateTime currentDateTime =  DateTime.Now;
            return currentDateTime;
        }
    

    public IActionResult Registration(Movie movie)
        {
            return View(movie);
        }

        public IActionResult Result(int ID, string Title, string Genre, int Year, string Actors, string Directors)
        {
            Movie movie = new Movie(ID, Title, Genre, Year, Actors, Directors);

            if (ModelState.IsValid)
            {
                return View(movie);
            }
            else
            {
                return RedirectToAction("Registration", movie);
            }

        }

        public IActionResult Result(Movie a)
        {
            return View(a);
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
