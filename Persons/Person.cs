// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private Address address;

        ///Properties
        public String FirstName
        {
            get { return firstName; }
            set 
            { 
                if (!string.IsNullOrEmpty(value))
                    firstName = value; 
            }
        }

        public String LastName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    lastName = value;
            }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public override string ToString()
        {
            return String.Format("Name({0} {1}) Address({2})",
                firstName,  // 0
                lastName,   // 1
                address);   // 2
        }
    }
}