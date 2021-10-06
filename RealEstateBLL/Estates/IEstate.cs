// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace RealEstateBLL
{
    public interface IEstate
    {
        [XmlIgnore]
        int EstateID { get; set; }
        [XmlIgnore]
        Address Address { get; set; }
        [XmlIgnore]
        Person Buyer { get; set; }
        [XmlIgnore]
        Person Seller { get; set; }
        [XmlIgnore]
        Payment Payment { get; set; }
        [XmlIgnore]
        LegalForm LegalForm { get; set; }
        [XmlIgnore]
        string ImagePath { get; set; }
    }
}