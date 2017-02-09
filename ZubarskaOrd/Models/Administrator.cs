using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrd.Models
{
    class Administrator
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Administrator(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
    }
}
