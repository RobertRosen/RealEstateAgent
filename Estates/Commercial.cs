// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Commercial : Estate
    {
        private int storageSquareMeters;

        ///Property
        public int StorageSquareMeters
        {
            get { return storageSquareMeters; }
            set { storageSquareMeters = value; }
        }

        public override bool acceptPayment(PaymentMethods paymentMethod)
        {
            return paymentMethod != PaymentMethods.PayPal;
        }
    }
}