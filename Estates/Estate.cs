using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RealEstateAgent
{
    public abstract class Estate : IEstate
    {
        private int estateID;
        private Address address;
        private Person buyer;
        private Person seller;
        private Payment payment;
        private LegalForm legalForm;
        private Image image;

        public int EstateID
        {
            get { return estateID; }
            set 
            { 
                if(value > 0)
                    estateID = value; 
            }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public Person Buyer
        {
            get { return buyer; }
            set { buyer = value; }
        }
        
        public Person Seller
        {
            get { return seller; }
            set { seller = value; }
        }

        public Payment Payment
        {
            get { return payment; }
            set { payment = value; }
        }

        public LegalForm LegalForm
        {
            get { return legalForm; }
            set { legalForm = value; }
        }

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public override string ToString()
        {
            return String.Format("ID({0}) - ADDRESS({1}) - BUYER({2}) - SELLER({3}) - PAYMENT({4}) - LEGALFORM: {5}",
                estateID,               // 0
                address,                // 1
                buyer,                  // 2
                seller,                 // 3
                payment,                // 4
                legalForm.ToString());  // 5
        }
    }
}