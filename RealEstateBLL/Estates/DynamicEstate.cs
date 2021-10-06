using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL
{
    public class DynamicEstate
    {
        public IEstate CreateEstateDynamic(EstateType estateType) => estateType switch
        {
            EstateType.Rental => new Rental(),
            EstateType.School => new School(),
            EstateType.Store => new Store(),
            EstateType.Tenement => new Tenement(),
            EstateType.Townhouse => new Townhouse(),
            EstateType.University => new University(),
            EstateType.Villa => new Villa(),
            EstateType.Warehouse => new Warehouse(),
            _ => throw new ArgumentException(message: "Invalid enum value", paramName: nameof(estateType))
        };
    }
}
