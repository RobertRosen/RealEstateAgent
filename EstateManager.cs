using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgent
{
    class EstateManager
    {
        private IEstate estate = null;
        private List<IEstate> lstEstates = new List<IEstate>();

        public IEstate CreateEstate(EstateType estateType)
        {
            //Dynamic binding.
            switch (estateType)
            {
                case EstateType.Apartment:
                    {
                        estate = new Apartment();
                        //TODO. Get legalform. Type casting? 
                        break;
                    }
                case EstateType.School:
                    {
                        estate = new School();
                        break;
                    }
                case EstateType.Store:
                    {
                        estate = new Store();
                        break;
                    }
                case EstateType.University:
                    {
                        estate = new University();
                        break;
                    }
                case EstateType.Villa:
                    {
                        estate = new Villa();
                        break;
                    }
                case EstateType.Warehouse:
                    {
                        estate = new Warehouse();
                        break;
                    }
                default: break;
            }
           
            estate.EstateID = lstEstates.Count;

            return estate;
        }

        public List<IEstate> AddEstateToRegister()
        {
            if (estate != null)
            {
                lstEstates.Add(estate);
            }

            return lstEstates;
        }

        public void SetAddress(Address address)
        {
            estate.Address = address;
        }

        public void SetEstateInfo(Address address, LegalForm legalForm)
        {
            estate.Address = address;
            
        }
    }
}
