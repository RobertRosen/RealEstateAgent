// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class University : Institutional
    {
        private int numberOfLectureHalls;

        ///Property
        public int NumberOfLectureHalls
        {
            get { return numberOfLectureHalls; }
            set { numberOfLectureHalls = value; }
        }
    }
}