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

        public override string ToString()
        {
            return String.Format("{0} , LEGALFORM: {1}", 
                base.ToString(),        // 0
                LegalForm.ToString());  // 1
        }
    }
}