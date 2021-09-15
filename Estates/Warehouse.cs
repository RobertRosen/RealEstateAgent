using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Warehouse : Commercial
    {
        private int numberOfLoadingDocks;

        public int NumberOfLoadingDocks
        {
            get { return numberOfLoadingDocks; }
            set { numberOfLoadingDocks = value; }
        }
    }
}