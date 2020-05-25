using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesRegistration.Models;

namespace MoviesRegistration.Controllers
{
    public class MovieController : Controller
    {
        const string shoppingCartKey = "ShoppingCartSession";

        public List<RentMovie> Movies = new List<RentMovie>()
        {
            new RentMovie(0, "Dude Wheres My Car?", "Comedy", 2000, 120, 6.99),
            new RentMovie(1, "Dude Wheres My Mom?", "Comedy", 2000, 120, 6.99),
            new RentMovie(2, "Dude Wheres My Girlfriend?", "Comedy", 2000, 120, 6.99),
            new RentMovie(3, "Dude Wheres My Dog?", "Comedy", 2000, 120, 6.99),
            new RentMovie(4, "Dude Wheres My House?", "Comedy", 2000, 120, 6.99),
            new RentMovie(5, "Dude Wheres My Clothes?", "Comedy", 2000, 120, 6.99)
        };

        public List<RentMovie> shoppingCart = new List<RentMovie>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowTable()
        {
            return View(Movies);
        }

        public IActionResult AddToCart(RentMovie movie)
        {
            AddMovieToSession(shoppingCartKey, movie, "shopping");

            return RedirectToAction("ToCart");
        }



        public void AddMovieToSession(string key, RentMovie movie, string type)
        {
            if (type == "shopping")
            {
               
                shoppingCart.Add(movie);
                SetSession(key, shoppingCart, type);
                shoppingCart = GetSession(key, type);
            }
            else
            {
                Movies = GetSession(key, type);
                Movies.Add(movie);
                SetSession(key, Movies, type);
            }
        }



        public IActionResult ToCart()
        {
            shoppingCart = GetSession(shoppingCartKey, "shopping");

            return View(shoppingCart);
        }



        public List<RentMovie> GetSession(string key, string type)
        {
            
            string jsonData = HttpContext.Session.GetString(key);

            if (jsonData != null)
            {
                if (type == "movie")
                {
                    Movies = JsonSerializer.Deserialize<List<RentMovie>>(jsonData);
                    return Movies;
                }
                else if (type == "shopping")
                {
                    shoppingCart = JsonSerializer.Deserialize<List<RentMovie>>(jsonData);
                    return shoppingCart;
                }
            }

            return null;
        }

        public void SetSession(string key, object value, string type)
        {
            shoppingCart = GetSession(key, type);

            string jsonData = JsonSerializer.Serialize(value);

            HttpContext.Session.SetString(key, jsonData);
        }

       
    }
}
