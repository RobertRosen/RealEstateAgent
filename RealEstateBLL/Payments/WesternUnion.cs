// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL
{
    [Serializable]
    public class WesternUnion : Payment
    {
        private String name;
        private String email;

        ///Properties
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

        public override string ToString()
        {
            return String.Format("{0} Name({1}) email({2})",
                base.ToString(),    // 0
                name,               // 1
                email);             // 2
        }
    }
}