// Joakim Tell & Robert Rosencrantz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Diagnostics;
using UtilitiesLib;

namespace RealEstateApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //--------------------------Testing Utilities--------------------------//
            Debug.WriteLine(StringConverter.ParseStringToInteger("12"));
            Debug.WriteLine(StringConverter.ParseStringToDouble("12"));
            Debug.WriteLine(StringConverter.ParseStringToInteger("12", 10, 15));
            Debug.WriteLine(StringConverter.ParseStringToDouble("12", 10, 15));

            Debug.WriteLine(StringConverter.ParseStringToInteger("tt"));
            Debug.WriteLine(StringConverter.ParseStringToDouble("tt"));
            Debug.WriteLine(StringConverter.ParseStringToInteger("9", 10, 15));
            Debug.WriteLine(StringConverter.ParseStringToDouble("32", 10, 15));
            //---------------------------------------------------------------------//

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
