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
    }
}