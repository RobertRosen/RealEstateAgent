using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Warehouse : Commercial
    {
        private bool hasLoadingDock;

        public bool HasLoadingDock
        {
            get { return hasLoadingDock; }
            set { hasLoadingDock = value; }
        }
    }
}