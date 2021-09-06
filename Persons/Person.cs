using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Person
    {
        private String name;
        private Address address;

        public String Name
        {
            get { return name; }

            set { name = value; }
        }

        public Address Address
        {
            get { return address; }

            set { address = value; }
        }
    }
}