using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public interface IEstate
    {
        int EstateID 
        { 
            get; 
            set; 
        }

        Address Address 
        { 
            get; 
            set; 
        }

        Person Person { get; set; }
    }
}