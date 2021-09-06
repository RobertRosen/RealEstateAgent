using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Estate : IEstate
    {
        private int estateID;

        public int EstateID
        {
            get { return estateID; }
            set 
            { 
                if(value > 0)
                    estateID = value; 
            }
        }
    }
}