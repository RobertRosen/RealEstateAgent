// Joakim Tell & Robert Rosencrantz

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

        /// <summary>
        /// Properties.
        /// </summary>
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

        /// <summary>
        /// Check if selected payment method is acceptable for the type of estate.
        /// </summary>
        /// <param name="paymentMethod"></param>
        /// <returns>true if payment method is accepted.</returns>
        public abstract bool acceptPayment(PaymentMethods paymentMethod);

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - {4} - {5}",
                estateID,               // 0
                address,                // 1
                buyer.LastName,         // 2
                seller.LastName,        // 3
                payment.Method,         // 4
                legalForm.ToString());  // 5
        }
    }
}