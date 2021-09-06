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
    }
}