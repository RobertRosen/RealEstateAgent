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

        public void SetEstateInfo(Address address, LegalForm legalForm)
        {
            if (estate.GetType() == typeof(Apartment))
            {
                ((Apartment)estate).LegalForm = legalForm;
            }

            estate.Address = address;
        }
        
        public void SetBuyerInfo(Address address, string name)
        {
            estate.Buyer = new Buyer();
            ((Buyer)estate.Buyer).Name = name;
            ((Buyer)estate.Buyer).Address = address;
        }

        public void SetSellerInfo(Address address, string name)
        {
            estate.Seller = new Seller();
            ((Seller)estate.Seller).Name = name;
            ((Seller)estate.Seller).Address = address;
        }

         public void SetPaymentInfo(PaymentMethods paymentMethod, string amount, string comment)
        {

            Payment payment = null;

            switch (paymentMethod)
            {
                case PaymentMethods.Bank:
                    {
                        payment = new Bank();
                        ((Bank)payment).Name = "Hardcoded Name";
                        ((Bank)payment).Accountnumber = "123456789-0";
                        break;
                    }
                case PaymentMethods.Western_Union:
                    {
                        payment = new WesternUnion();
                        ((WesternUnion)payment).Name = "Hardcoded Name";
                        ((WesternUnion)payment).Email = "hardcoded@email.com";
                        break;
                    }
                case PaymentMethods.PayPal:
                    {
                        payment = new PayPal();
                        ((PayPal)payment).Email = "hardcoded@email.com";
                        break;
                    }
                default: break;
            }

            payment.Amount = Convert.ToDouble(amount);
            payment.Comment = comment;

            estate.Payment = payment;
        }
    }
}
