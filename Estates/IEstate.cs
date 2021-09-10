using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public interface IEstate
    {
        int EstateID { get; set; }
        Address Address { get; set; }
        Person Buyer { get; set; }
        Person Seller { get; set; }
        Payment Payment { get; set; }
    }
}