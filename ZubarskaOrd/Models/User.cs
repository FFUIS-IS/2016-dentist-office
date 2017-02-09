using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrd.Models
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public static bool IsAdminUser { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Role()
        {
            if (IsAdminUser == true)
                return "Administrator";
            else
                return "Regular user";
        }
    }
}
