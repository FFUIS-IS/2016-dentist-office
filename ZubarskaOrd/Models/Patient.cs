using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrd.Models
{
    class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public  string City { get; set; }

        public Patient(int id, string firstName, string lastName, string dateOfBirth, string contact, string address, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Contact = contact;
            Address = address;
            City = city;
        }
    }

    
}
