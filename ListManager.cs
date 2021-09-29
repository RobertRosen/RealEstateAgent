using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            bool success;

            if (fileName == null)
            {
                success = true;
            }
            else
            {
                success = false;
            }

            return success;
        }

        public bool BinarySerialize(string fileName)
        {
            bool success;

            if(fileName != null)
            {
                success = true;
            }
            else
            {
                success = false;
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
            bool success;

            if (aType != null && anIndex > -1)
            {
                list[anIndex] = aType;
                success = true;
            }
            else
            {
                success = false;
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
            bool indexOk;

            if (index >= 0 && index < Count)
            {
                indexOk = true;
            }
            else
            {
                indexOk = false;
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

            for(int i = 0; i < list.Count; i++)
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
            throw new NotImplementedException();
        }
    }
}
