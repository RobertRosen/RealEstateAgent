using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RealEstateAgent
{
    class EstateManager : ListManager<IEstate>
    {
        private int estateIDCounter;

        public int EstateIDCounter 
        {
            get { return estateIDCounter; }
            set { estateIDCounter = value; }
        }

        /// <summary>
        /// Add one to estate counter and return the new value of the counter.
        /// </summary>
        /// <returns>estate id counter</returns>
        public int incrementEstateIDCounter()
        {
            return ++estateIDCounter;
        }

        public string[] SearchEstate(string searchCity)
        {
            int estateCount = base.Count;

            Dictionary<string, List<IEstate> > keyValuePairs = new Dictionary<string, List<IEstate> >();

            for (int i = 0; i < estateCount; i++)
            {
                IEstate estate = base.GetAt(i);
                string city = estate.Address.City;
                if (!keyValuePairs.ContainsKey(city))
                {
                    List<IEstate> cityEstateList = new List<IEstate>();
                    keyValuePairs.Add(city, cityEstateList);
                }
                keyValuePairs[city].Add(estate);
            }

            List<IEstate> searchEstateList;
            try 
            {
                searchEstateList = keyValuePairs[searchCity];
            }
            catch
            {
                return null;
            }
                
            string[] stringArray = new string[searchEstateList.Count];

            for (int i = 0; i < searchEstateList.Count; i++)
            {
                string strAti = searchEstateList[i].ToString();
                stringArray[i] = strAti;
            }

            return stringArray;
        }
       
        /// <summary>
        /// Read an xml-file containing a list of estate object, 
        /// transform and replace the list of Iestates. 
        /// </summary>
        /// <param name="filePath"></param>
        public void ReadEstateListFromXmlFile(string filePath)
        {
            TextReader reader = null;
            List<Estate> estateList = new List<Estate>();
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Estate>));
                reader = new StreamReader(filePath);
                estateList = (List<Estate>)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            base.DeleteAll();
            foreach (Estate est in estateList)
            {
                IEstate iest = (IEstate)est;
                base.Add(iest);
                EstateIDCounter++;
            }
        }
    }
}
