// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Institutional : Estate
    {
        private int numberOfCafeterias;
        private int numberOfClassrooms;

        ///Properties
        public int NumberOfCafeterias
        {
            get { return numberOfCafeterias; }
            set { numberOfCafeterias = value; }
        }

        public int NumberOfClassrooms
        {
            get { return numberOfClassrooms; }
            set { numberOfClassrooms = value; }
        }

        public override bool acceptPayment(PaymentMethods paymentMethod)
        {
            return paymentMethod == PaymentMethods.Bank;
        }
    }
}