using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    [Serializable]
    public class Rental : Apartment
    {
        private int contractMonths;

        public int ContractMonths
        {
            get { return contractMonths; }
            set { contractMonths = value; }
        }
    }
}