﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class WesternUnion : Payment
    {
        private String name;
        private String email;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}