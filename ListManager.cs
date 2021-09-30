using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace RealEstateAgent
{
    class ListManager<T> : IListManager<T>
    {
        private List<T> list;
        private int count;

        public ListManager()
        {
            list = new List<T>();
        }


        [XmlIgnore]
        public List<T> List { get; set; }

        [XmlArrayItem(ElementName = "T")]
        [XmlArray(ElementName = "List")]
        public List<T> SerializableTs
        {
            get
            {
                return List.Cast<T>().ToList();
            }
            set
            {
                List = new List<T>(value);
            }
        }

        // Properties
        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// Add a new object to the list.
        /// </summary>
        /// <param name="aType"></param>
        /// <returns></returns>
        public bool Add(T aType)
        {
            bool success;

            if (aType != null)
            {
                list.Add(aType);
                count++;
                success = true;
            }
            else
            {
                success = false;
            }

            return success;
        }

        public bool BinaryDeSerialize(string fileName)
        {
            bool success = false;

            if (fileName != null)
            {
                using (Stream stream = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    list.Clear();
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                    list = (List<T>)binaryFormatter.Deserialize(stream);
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                    success = true;
                }
            }
            return success;
        }

        public bool BinarySerialize(string fileName)
        {
            bool success = false;

            if (fileName != null)
            {
                using (Stream stream = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                    binaryFormatter.Serialize(stream, list);
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                    success = true;
                }
            }
            return success;
        }

        /// <summary>
        /// Replace (change) an object in a position with a new object. 
        /// </summary>
        /// <param name="aType"></param>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public bool ChangeAt(T aType, int anIndex)
        {
            bool success = false;

            if (aType != null && anIndex > -1)
            {
                list[anIndex] = aType;
                success = true;
            }
            return success;
        }

        /// <summary>
        /// Control that a given index is >= 0 and less than the number of items in 
        /// the collection.
        /// </summary>
        /// <returns>True if successful, false otherwise.</returns>
        public bool CheckIndex(int index)
        {
            bool indexOk = false;

            if (index >= 0 && index < Count)
            {
                indexOk = true;
            }

            return indexOk;
        }

        /// <summary>
        /// Deletes all object of the collection and set the collection to null.
        /// </summary>
        public void DeleteAll()
        {
            list.Clear();
        }

        /// <summary>
        /// Remove an object from the list at a certain position.
        /// </summary>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public bool DeleteAt(int anIndex)
        {
            bool success = CheckIndex(anIndex);

            if (success)
            {
                list.RemoveAt(anIndex);
                count--;
                success = true;
            }
            else
            {
                success = false;
            }

            return success;
        }

        /// <summary>
        /// Return an object from a certain position in the list.
        /// </summary>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public T GetAt(int anIndex)
        {
            T obj;
            bool indexOk = CheckIndex(anIndex);

            if (indexOk)
            {
                obj = list[anIndex];
            }
            else
            {
                obj = default(T);
            }
            return obj;
        }

        /// <summary>
        /// Return an array of strings where every string is represents the object 
        /// (calling the ToString() of the object). 
        /// </summary>
        /// <returns></returns>
        public string[] ToStringArray()
        {
            string[] stringArray = new string[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                string strAti = list[i].ToString();
                stringArray[i] = strAti;
            }

            return stringArray;
        }

        public List<string> ToStringList()
        {
            List<string> stringList = null;

            for (int i = 0; i < list.Count; i++)
            {
                stringList[i] = list.ElementAt(i).ToString();
            }

            return stringList;
        }

        public bool XMLSerialize(string fileName)
        {
            bool success = false;

            if (fileName != null)
            {
                TextWriter writer = null;
                try
                {
                    XmlSerializer serializer = new XmlSerializer(T.GetType());
                    writer = new StreamWriter(fileName);
                    serializer.Serialize(writer, list);
                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                }
            }
            return success;
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///
        /// <summary>
        /// Writes the given object instance to an XML file.
        /// <para>Only Public properties and variables will be written to the file. These can be any type though, even other classes.</para>
        /// <para>If there are public properties/variables that you do not want written to the file, decorate them with the [XmlIgnore] attribute.</para>
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(filePath, append);
                serializer.Serialize(writer, objectToWrite);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// Reads an object instance from an XML file.
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object to read from the file.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the XML file.</returns>
        public static T ReadFromXmlFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(filePath);
                return (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
