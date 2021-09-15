using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Store : Commercial
    {
        private string suitableBusiness;

        public string SuitableBusiness
        {
            get { return suitableBusiness; }
            set { suitableBusiness = value; }
        }
    }
}