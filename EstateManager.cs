using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgent
{
    class EstateManager : ListManager<IEstate>
    {
        private int estateIDCounter;

        public int EstateIDCounter 
        {
            get { return estateIDCounter; }
            set { estateIDCounter = value; }
        }

        /// <summary>
        /// Add one to estate counter and return the new value of the counter.
        /// </summary>
        /// <returns>estate id counter</returns>
        public int incrementEstateIDCounter()
        {
            return ++estateIDCounter;
        }
    }
}
