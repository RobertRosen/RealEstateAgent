// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL
{
    [Serializable]
    public class Address
    {
        private String street;
        private String zipCode;
        private String city;
        private Countries country;

        public Address()
        {
        }

        public Address(string street, string zipCode, string city, Countries country)
        {
            this.street = street;
            this.zipCode = zipCode;
            this.city = city;
            this.country = country;
        }

        ///Properties
        public String Street
        {
            get { return street; }

            set { street = value; }
        }

        public String ZipCode
        {
            get { return zipCode; }

            set { zipCode = value; }
        }

        public String City
        {
            get { return city; }

            set { city = value; }
        }

        public Countries Country
        {
            get { return country; }

            set { country = value; }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}",
                street,     // 0
                zipCode,    // 1
                city,       // 2
                country);   // 3
        }
    }
}