using RealEstateDAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using UtilitiesLib;

namespace RealEstateBLL
{
    public class EstateManager : ListManager<IEstate>
    {
        private int estateIDCounter = 0;

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

        public void WriteEstateListToXmlFile(string fileName)
        {
            ListManager<Estate> listManager = new ListManager<Estate>();
            foreach (IEstate iest in List)
            {
                Estate estate = (Estate)iest;
                listManager.Add(estate);
            }

            listManager.XMLSerialize(fileName);
        }

        /// <summary>
        /// Read an xml-file containing a list of estate object, 
        /// transform and replace the list of Iestates. 
        /// </summary>
        /// <param name="filePath"></param>
        public void ReadEstateListFromXmlFile(string filePath)
        {
            ListManager<Estate> listManager = new ListManager<Estate>();
            listManager.XMLDeserialize(filePath);

            base.DeleteAll();
            foreach (Estate est in listManager.List)
            {
                IEstate iestate = (IEstate)est;
                base.Add(iestate);
                EstateIDCounter++;
            }
        }
    }
}
