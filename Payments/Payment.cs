using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Payment
    {
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
            return String.Format("PAYMENT(Amount({0}) Comment({1}))",
                amount,     // 0
                comment);   // 1
        }
    }
}