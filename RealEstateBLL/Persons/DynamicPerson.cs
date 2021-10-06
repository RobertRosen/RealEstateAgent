using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL
{
    public class DynamicPerson
    {
        public Person CreatePersonDynamic(PersonTypes person, string fname, string lname, Address address) => person switch
        {
            PersonTypes.Buyer => new Buyer(fname, lname, address),
            PersonTypes.Seller => new Seller(fname, lname, address),
            _ => throw new ArgumentException(message: "Invalid enum value", paramName: nameof(person))
        };
    }
}
