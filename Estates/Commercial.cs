using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Commercial : Estate
    {
        private int storageSquareMeters;

        public int StorageSquareMeters
        {
            get { return storageSquareMeters; }
            set { storageSquareMeters = value; }
        }
    }
}