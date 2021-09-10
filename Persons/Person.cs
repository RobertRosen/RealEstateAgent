using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Person
    {
        private string name;
        private Address address;

        public String Name
        {
            get { return name; }
            set 
            { 
                if (!string.IsNullOrEmpty(value))
                    name = value; 
            }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public override string ToString()
        {
            return String.Format("Name({0}) Address({1})",
                name,       // 0
                address);   // 1
        }
    }
}