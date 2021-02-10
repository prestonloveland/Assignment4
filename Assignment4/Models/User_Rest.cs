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
    //class to create a user entered restaurant
    public class User_Rest
    {
        public string UserName { get; set; }
        public string RestaurantName { get; set; }
        public string FavoriteDish { get; set; }
        //ensure it is a valid number
        [Required, Phone, RegularExpression(@"^(1-)?\d{3}-\d{3}-\d{4}$", ErrorMessage = "Must be in standard US Phone Number Format ex: 123-456-7890")]
        public string PhoneNumber { get; set; }

    }
}
