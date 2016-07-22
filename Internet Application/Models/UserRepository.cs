using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Internet_Application.Models
{
    public class UserRepository
    {
        public bool Exists(string nickName)
        {
            var invalidNames = new[] { "john", "peter", "mark", "jose" };
            return invalidNames.Any(n => n == nickName);
        }
    }
}