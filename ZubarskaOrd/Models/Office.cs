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
        public string Name { get; set; }

        public Office(int id, string officeName, string address)
        {
            Id = id;
            OfficeName = officeName;
            Address = address;
        }
    }
}
