﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Apartment : Residental
    {
        private int floor;

        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }
    }
}