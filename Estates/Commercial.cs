// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    [Serializable]
    public abstract class Commercial : Estate
    {
        private int storageSquareMeters;

        //Property
        public int StorageSquareMeters
        {
            get { return storageSquareMeters; }
            set { storageSquareMeters = value; }
        }

        /// <summary>
        /// Check if selected payment method is acceptable for the type of estate.
        /// </summary>
        /// <param name="paymentMethod"></param>
        /// <returns>true if payment method is accepted.</returns>
        public override bool acceptPayment(PaymentMethods paymentMethod)
        {
            return paymentMethod != PaymentMethods.PayPal;
        }
    }
}