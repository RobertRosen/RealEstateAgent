// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    [Serializable]
    public class Apartment : Residental
    {
        private int floor;

        /// <summary>
        /// Property.
        /// </summary>
        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }
    }
}