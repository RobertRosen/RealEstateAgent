using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Apartment : Residental
    {
        LegalForm legalForm;

        public LegalForm LegalForm
        {
            get { return legalForm; }
            set { legalForm = value; }
        }
    }
}