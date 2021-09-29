// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    [Serializable]
    public class Warehouse : Commercial
    {
        private int numberOfLoadingDocks;

        ///Property
        public int NumberOfLoadingDocks
        {
            get { return numberOfLoadingDocks; }
            set { numberOfLoadingDocks = value; }
        }
    }
}