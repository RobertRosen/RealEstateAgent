using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class School : Institutional
    {
        private bool hasGymnasium;

        public bool HasGymnasium
        {
            get { return hasGymnasium; }
            set { hasGymnasium = value; }
        }
    }
}