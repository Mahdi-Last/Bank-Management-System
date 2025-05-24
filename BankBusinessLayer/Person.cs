using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class Person
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        protected Person(int id, string firstName, string lastName, string email, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Person() 

        {
            Id = -1;
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";

          
         }
    }
}
