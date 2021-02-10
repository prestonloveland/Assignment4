/*
 * Preston Loveland
 * Assignemnt 4
 * Section 1 Group 11
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    //Class to hold list of restaurant objects
    public class DataStorage
    {
        private static List<User_Rest> restaurants = new List<User_Rest>();

        public static IEnumerable<User_Rest> Rests => restaurants;

        public static void AddRest(User_Rest restaurant)
        {
            restaurants.Add(restaurant);
        }
    }
}
