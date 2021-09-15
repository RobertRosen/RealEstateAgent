using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Residental : Estate
    {
        private int squareMeter;

        public int SquareMeter
        {
            get { return squareMeter; }
            set { squareMeter = value; }
        }
    }
}