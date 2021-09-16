using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public abstract class Residental : Estate
    {
        private int squareMeter;

        public int SquareMeter
        {
            get { return squareMeter; }
            set { squareMeter = value; }
        }

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