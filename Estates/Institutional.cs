using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Institutional : Estate
    {
        private int numberOfCafeterias;
        private int numberOfClassrooms;

        public int NumberOfCafeterias
        {
            get { return numberOfCafeterias; }
            set { numberOfCafeterias = value; }
        }

        public int NumberOfClassrooms
        {
            get { return numberOfClassrooms; }
            set { numberOfClassrooms = value; }
        }
    }
}