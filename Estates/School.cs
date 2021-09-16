// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class School : Institutional
    {
        private string suitableLevel;

        ///Property
        public string SuitableLevel
        {
            get { return suitableLevel; }
            set { suitableLevel = value; }
        }
    }
}