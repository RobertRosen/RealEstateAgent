// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL
{
    [Serializable]
    public class Store : Commercial
    {
        private string suitableBusiness;

        ///Property
        public string SuitableBusiness
        {
            get { return suitableBusiness; }
            set { suitableBusiness = value; }
        }
    }
}