using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;

namespace RealEstateDAL
{
    public class EstatesDAO
    {
        public void SaveListToFile()
        {

        }

        public void RetrieveListFromFile()
        {

        }

        public void BinarySerialize<T>(string fileName)
        {
            new ListManager<T>().BinarySerialize(fileName);
        }

        public void BinaryDeSerialize<T>(string fileName)
        {
            new ListManager<T>().BinaryDeSerialize(fileName);
        }

        public void WriteToXml<T>(string fileName)
        {
            new ListManager<T>().XMLSerialize(fileName);
        }
    }
}
