using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Institutional : Estate
    {
        private bool hasCafeteria;
        private int numberOfClassrooms;

        public bool HasCafeteria
        {
            get { return hasCafeteria; }
            set { hasCafeteria = value; }
        }

        public int NumberOfClassrooms
        {
            get { return numberOfClassrooms; }
            set { numberOfClassrooms = value; }
        }
    }
}