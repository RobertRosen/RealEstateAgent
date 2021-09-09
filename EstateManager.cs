using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgent
{
    class EstateManager
    {
        private List<IEstate> estates = new List<IEstate>();
        private MainForm mainForm;

        public EstateManager(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public void CreateEstate(EstateType estateType)
        {
            IEstate estate = null;

            switch (estateType)
            {
                case EstateType.Apartment:
                    {
                        estate = new Apartment();
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
            if (estate != null)
            {
                estates.Add(estate);
            }
            estate.EstateID = estates.Count;
           
        }
    }
}
