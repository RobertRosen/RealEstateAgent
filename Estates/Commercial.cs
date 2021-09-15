using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Commercial : Estate
    {
        private bool hasOfficeSpace;

        public bool HasOfficeSpace
        {
            get { return hasOfficeSpace; }
            set { hasOfficeSpace = value; }
        }
    }
}