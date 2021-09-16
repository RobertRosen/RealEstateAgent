// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Villa : Residental
    {
        private int gardenSquareMeters;

        ///Property
        public int GardenSquareMeters
        {
            get { return gardenSquareMeters; }
            set { gardenSquareMeters = value; }
        }
    }
}