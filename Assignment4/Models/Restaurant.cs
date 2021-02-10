/*
 * Preston Loveland
 * Assignment 4
 * Section 1 Group 11
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    //class to create top 5 restaurants
    public class Restaurant
    {
        [Required]
        public int Rank { get; private set; }
        [Required]
        public string Name { get; set; }
        public string Favorite_Dish { get; set; }
        [Required]
        public string? Address { get; set; }
        public string Phone_Number { get; set; }
        public string? Website { get; set; } = "Coming Soon";

        //method to create instances of class and add them to a List
        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant
            {
                Rank = 1,
                Name = "Cup Bop",
                Favorite_Dish = "Pork",
                Address = "356 University Ave",
                Phone_Number = "545-558-7873",
                Website = "www.cupbop.com"
            };

            Restaurant r2 = new Restaurant
            {
                Rank = 2,
                Name = "In N' Out",
                Favorite_Dish = "Double-Double",
                Address = "7787 Cougar Blvd",
                Phone_Number = "788-213-0487",
                Website = "www.innout.com"
            };

            Restaurant r3 = new Restaurant
            {
                Rank = 3,
                Name = "Magleby's",
                Favorite_Dish = null,
                Address = "854 E 789 W, Sprigville, Utah",
                Phone_Number = "545-554-4545",
                Website = "www.maglebys.com"
            };

            Restaurant r4 = new Restaurant
            {
                Rank = 4,
                Name = "Tucanos",
                Favorite_Dish = "Buffet",
                Address = "7895 University Ave",
                Phone_Number = "804-559-3658",
                Website = "www.tucanos.com"
            };

            Restaurant r5 = new Restaurant
            {
                Rank = 5,
                Name = "Zupas Cafe",
                Favorite_Dish = null,
                Address = "189 E 587 N, Provo Utah",
                Phone_Number = "885-216-5484",
            };

            return new Restaurant[] { r1, r2, r3, r4, r5};
        }
    }
}
