// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;

namespace RealEstateAgent
{
    [Serializable()]
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("EstateID", estateID);
            info.AddValue("Address", address);
            info.AddValue("Buyer", buyer);
            info.AddValue("Seller", seller);
            info.AddValue("Payment", payment);
            info.AddValue("LegalForm", legalForm);
            info.AddValue("Image", image);
        }

        public Estate(SerializationInfo info, StreamingContext context)
        {
            estateID = (int)info.GetValue("EstateID", typeof(int));
            address = (Address)info.GetValue("EstateID", typeof(Address));
            buyer = (Buyer)info.GetValue("EstateID", typeof(Buyer));
            seller = (Seller)info.GetValue("EstateID", typeof(Seller));
            payment = (Payment)info.GetValue("EstateID", typeof(Payment));
            legalForm = (LegalForm)info.GetValue("EstateID", typeof(LegalForm));
            image = (Image)info.GetValue("EstateID", typeof(Image));
           
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6}",
                estateID,               // 0
                this.GetType().Name,    // 1
                address,                // 2
                buyer.LastName,         // 3
                seller.LastName,        // 4
                payment.Method,         // 5
                legalForm.ToString());  // 6
        }
    }
}