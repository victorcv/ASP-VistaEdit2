using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Internet_Application.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Internet_Application.Models
{
    public class UserViewModel
    {
        [Required,StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(20,MinimumLength = 3),Remote("UsernameAvailable", "User", ErrorMessage = "Nick already exists")]
        public string Nickname { get; set; }

        [Range(1,3)]
        [UIHint("UserTypeEditor")]
        public int Type { get; set; }

        [Required,EmailAddress, StringLength(100)]
        public string Email { get; set; }

        [Required, StringLength(20, MinimumLength = 5)]
        public string Password { get; set; }

        [Required, StringLength(20, MinimumLength = 5), System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password mismatch")]
        public string RePassword { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public bool Enabled { get; set; }

        public IEnumerable<UserType> UserTypes { get; set; }
    }
}