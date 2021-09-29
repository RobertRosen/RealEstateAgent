// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    [Serializable]
    public abstract class Residental : Estate
    {
        private int squareMeter;

        ///Property
        public int SquareMeter
        {
            get { return squareMeter; }
            set { squareMeter = value; }
        }

        /// <summary>
        /// Check if selected payment method is acceptable for the type of estate.
        /// </summary>
        /// <param name="paymentMethod"></param>
        /// <returns>true if payment method is accepted.</returns>
        public override bool acceptPayment(PaymentMethods paymentMethod)
        {
            foreach(PaymentMethods payMet in Enum.GetValues(typeof(PaymentMethods))){
                if(paymentMethod == payMet)
                {
                    return true;
                }
            }
            return false;
        }
    }
}