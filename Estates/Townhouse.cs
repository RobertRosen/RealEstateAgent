// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Townhouse : Villa
    {
        private int numberOfConnectedVillas;

        ///Property
        public int NumberOfConnectedVillas
        {
            get { return numberOfConnectedVillas; }
            set { numberOfConnectedVillas = value; }
        }
    }
}