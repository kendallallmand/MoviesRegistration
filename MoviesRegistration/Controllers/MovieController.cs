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
            new RentMovie(0, 1,"Matrix", "Action", 2000, 120, 6.99),
            new RentMovie(1, 1,"Holes", "Drama", 2000, 120, 6.99),
            new RentMovie(2, 1,"iRobot", "Action", 2000, 120, 6.99),
            new RentMovie(3, 1,"Shrek", "Comedy", 2000, 120, 6.99),
            new RentMovie(4, 1,"Shrek2", "Comedy", 2000, 120, 6.99),
            new RentMovie(5, 1,"Shrek3", "Comedy", 2000, 120, 6.99)
        };

        public List<RentMovie> shoppingCart = new List<RentMovie>();
        public List<RentMovie> CheckedCart = new List<RentMovie>();

     
        public IActionResult Result(int ID, double Qty, string Title, string Genre, int Year, int RunTime, double RentalCost)
        {
            RentMovie movie = new RentMovie(ID, Qty, Title, Genre, Year, RunTime, RentalCost);

            if (ModelState.IsValid)
            {
                return View(movie);
            }
            else
            {
                return RedirectToAction("Registration", movie);
            }

        }

        public IActionResult Result(RentMovie a)
        {
            return View(a);
        }

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

            return RedirectToAction("");
        }


        public IActionResult ToCart()
        {
          
                shoppingCart = GetSession(shoppingCartKey, "shopping");
          
               
            
            return View(shoppingCart);
        }


        public IActionResult Checkout()
        {
          
            CheckedCart = GetSession(shoppingCartKey, "shopping");
            SetSession(shoppingCartKey, CheckedCart, "shopping");
          
            shoppingCart = GetSession(shoppingCartKey, "clear");
            SetSession(shoppingCartKey, shoppingCart, "shopping");

            return View(CheckedCart);
            
        }

        public IActionResult ToCheckout()
        {
           
                CheckedCart = GetSession(shoppingCartKey, "shopping");
                


            return RedirectToAction("Checkout");
        }

       


        public List<RentMovie> GetSession(string key, string type)
        {
            List<RentMovie> NewshoppingCart = new List<RentMovie>();
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
                else if (type == "clear")
                {
                    shoppingCart.Clear();
                    shoppingCart = new List<RentMovie>();
                    return shoppingCart;
                }
            }

            return NewshoppingCart;
        }

        public void SetSession(string key, object value, string type)
        {
            shoppingCart = GetSession(key, type);

            string jsonData = JsonSerializer.Serialize(value);

            HttpContext.Session.SetString(key, jsonData);
        }


        public void AddMovieToSession(string key, RentMovie movie, string type)
        {
            if (type == "shopping")
            {

                shoppingCart = GetSession(key, type);
                shoppingCart.Add(movie);
                SetSession(key, shoppingCart, type);
            }
            else
            {
                Movies = GetSession(key, type);
                Movies.Add(movie);
                SetSession(key, Movies, type);
            }
        }

       

     }
}
