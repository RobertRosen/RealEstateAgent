// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL
{
    [Serializable]
    public class Seller : Person
    {
        public Seller()
        {
        }

        public Seller(string firstName, string lastName, Address address) : base(firstName, lastName, address)
        {
        }
    }
}