using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgent
{
    class ListManager<T> : IListManager<T>
    {
        private List<T> list;

        public ListManager()
        {
            list = new List<T>();
        }
        public int Count => throw new NotImplementedException();

        /// <summary>
        /// Add a new object to the list.
        /// </summary>
        /// <param name="aType"></param>
        /// <returns></returns>
        public bool Add(T aType)
        {
            // Add a new object to the list.
            throw new NotImplementedException();
        }

        public bool BinaryDeSerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool BinarySerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Replace (change) an object in a position with a new object. 
        /// </summary>
        /// <param name="aType"></param>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public bool ChangeAt(T aType, int anIndex)
        {
            // Replace (change) an object in a position with a new object.
            throw new NotImplementedException();
        }

        public bool CheckIndex(int index)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove an object from the list at a certain position.
        /// </summary>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public bool DeleteAt(int anIndex)
        {
            // Remove an object from the list at a certain position.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return an object from a certain position in the list.
        /// </summary>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public T GetAt(int anIndex)
        {
            // Return an object from a certain position in the list.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return an array of strings where every string is represents the object 
        /// (calling the ToString() of the object). 
        /// </summary>
        /// <returns></returns>
        public string[] ToStringArray()
        {
            // Return an array of strings where every string is represents the object 
            // (calling the ToString() of the object). 
            throw new NotImplementedException();
        }

        public List<string> ToStringList()
        {
            throw new NotImplementedException();
        }

        public bool XMLSerialize(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
