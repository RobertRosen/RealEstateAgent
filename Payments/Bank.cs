// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class Bank : Payment
    {
        private String name;
        private String accountNumber;

        ///Properties
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Accountnumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public override string ToString()
        {
            return String.Format("{0} Name({1}) AccountNumber({2})",
                base.ToString(),    // 0
                name,               // 1
                accountNumber);     // 2
        }
    }
}