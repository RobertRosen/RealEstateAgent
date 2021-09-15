using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RealEstateAgent
{
    public interface IEstate
    {
        int EstateID { get; set; }
        Address Address { get; set; }
        Person Buyer { get; set; }
        Person Seller { get; set; }
        Payment Payment { get; set; }
        LegalForm LegalForm { get; set; }
        Image Image { get; set; }
    }
}