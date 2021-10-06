// Joakim Tell & Robert Rosencrantz
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL
{
    [Serializable]
    public class Buyer : Person
    {
        public Buyer()
        {
        }

        public Buyer(string firstName, string lastName, Address address) : base(firstName, lastName, address)
        {
        }

        public void differentiateFromSellermethod()
        {
            //ok
        }
    }
}