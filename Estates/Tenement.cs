// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Tenement : Apartment
    {
        private string tenantOwnersAssociationName;

        ///Property
        public string TenantOwnersAssociationName
        {
            get { return tenantOwnersAssociationName; }
            set { tenantOwnersAssociationName = value; }
        }
    }
}