﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class PayPal : Payment
    {
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public override string ToString()
        {
            return String.Format("{0} email({1})",
                base.ToString(),    // 0
                email);             // 1
        }
    }
}