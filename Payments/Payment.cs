using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Payment
    {
        private PaymentMethods method;
        private double amount;
        private String comment;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public String Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public override string ToString()
        {
            return String.Format("PAYMENT(Method({0}) Amount({1}) Comment({2}))",
                method,     // 0
                amount,     // 1
                comment);   // 2
        }
    }
}