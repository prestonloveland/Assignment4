/*
 * Preston Loveland
 * Assignment 4
 * Section 1 Group 11
 * */
using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //get index view, display list of top 5 restaurants
        public IActionResult Index()
        {
            List<string> restList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                string favorite = r.Favorite_Dish ?? "It's all tasty";

                restList.Add(string.Format("#{0}:  {1} <br> Favorite Dish: {2} <br> Address: {3} <br> Phone Number {4} <br> Website: <a href='{5}'>{5}</a>",
                    r.Rank, r.Name, favorite, r.Address, r.Phone_Number, r.Website));
            }

            return View(restList);
        }
        //get call for restaurant input page
        [HttpGet("Input")]
        public IActionResult Restaurant_Input()
        {
            return View();
        }
        //post for restaurant inpit page
        [HttpPost("List")]
        public IActionResult Restaurant_Input(User_Rest restaurant)
        {
            if (ModelState.IsValid)
            {
                DataStorage.AddRest(restaurant);
                return View("List", DataStorage.Rests);
            }
            return View();
        }
        //get call for the list of entered restaurants
        [HttpGet("List")]
        public IActionResult List()
        {
            return View(DataStorage.Rests);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
