using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgent
{
    // KOPIERAD FRÅN FARIDS KODEXEMPEL SERIALIZATION!!!
    class BinarySerialize
    {
        
        public static byte[] Serialize(object obj)
        {
            byte[] serializedObject = null;
            MemoryStream memStream = null;

            try
            {
                memStream = new MemoryStream();
                BinaryFormatter binFormatter = new BinaryFormatter();

                binFormatter.Serialize(memStream, obj);
                memStream.Seek(0, 0);			    //set position at 0,0
                serializedObject = memStream.ToArray();
            }
            finally
            {
                if (memStream != null)
                    memStream.Close();
            }

            return serializedObject;    // return the array.
        }

        /// <summary>
        /// Deserialize any type of array object.  The type (T) is defined when
        /// calling this function.
        /// </summary>
        /// <typeparam name="T">Any array type</typeparam>
        /// <param name="serializedObject">Array object containing data.</param>
        /// <returns>The array object containing the data read from the serializedObject.</returns>
        /// <remarks>Object must not have changed its structure since it was serilized calling
        /// the above method.</remarks>
        public static T Deserialize<T>(byte[] serializedObject)
        {
            object obj = null;    //object to return
            MemoryStream memStream = null;

            try
            {
                memStream = new MemoryStream();
                memStream.Write(serializedObject, 0, serializedObject.Length);
                memStream.Seek(0, 0);  //set position at 0,0

                BinaryFormatter binFormatter = new BinaryFormatter();
                obj = binFormatter.Deserialize(memStream);
            }
            catch //no parameter - catch avoids exception throwing but no action is taken here 
            {
            }
            finally
            {
                if (memStream != null)
                    memStream.Close();
            }

            return (T)obj;		// convert obj to correct type!
        }
    }
}
