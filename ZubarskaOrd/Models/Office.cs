using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrd.Models
{
    class Office
    {
        public int Id { get; set; }
        public string OfficeName { get; set; }
        public string Address { get; set; }
        public static string Name { get; set; }

        public Office(string officeName)
        {
            OfficeName = officeName;
        }
    }
}
