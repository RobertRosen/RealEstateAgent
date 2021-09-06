using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Address
    {
        private String street;
        private String zipCode;
        private String city;
        private Countries country;

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
    }
}