using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook2
{
    public class Person
    {
        public string Name;
        public string Address;
        public string City;
        public string State;
        public string Zip;
        public string PhoneNumber;
        public string Email;

        public Person(string name, string address, string city, string state, string zip, string phonenumber, string email)
        {
            Name = name;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phonenumber;
            Email = email;

        }
    }
}
