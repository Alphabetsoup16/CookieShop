using System;
using System.ComponentModel.DataAnnotations;

namespace CookieShop.Shared
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }




    }
}
